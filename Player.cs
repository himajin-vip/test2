using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  public string Name;
  public int Level;
  public int MaxHp;
  public int CurrentHp;
  public int MaxMp;
  public int CurrentMp;
  public int Str;
  public int Def;
  public int MoveSpeed;
  public int Direction;
  public float PosX;
  public float PosY;
  public int ChargeMoveSpeed;
  public int NomalMoveSpeed;
  public bool AtackAnimation = false;
  public bool AtackOn = false;
  public bool ChargeEfectOn = false;
  public bool FullCharge = false;
  public bool KeyUp = false;
  Coroutine ChargeC ;
  GameObject ChargeEfect;
  GameObject MyWeapon;

  public void SetMyWeapon(){
    MyWeapon = transform.GetChild(0).gameObject;
  }

  public void DamageHp(int damage){
    CurrentHp -= damage;
    float x = this.transform.position.x;
    float y = this.transform.position.y;
    DamageTextManager.Make(damage,x,y,new Color(255,0,0),this.transform);
  }
  public void RecoveryHp(int recovery){
    CurrentHp += recovery;
    if(CurrentHp>MaxHp){
      CurrentHp = MaxHp;
    }
    float x = this.transform.position.x;
    float y = this.transform.position.y;
    DamageTextManager.Make(recovery,x,y,new Color(0,255,0),this.transform);
    EfectManager.efecton("kaihukuefect",this.transform.position.x,this.transform.position.y,this.gameObject);
  }
  public void SetMaxHp(){
    CurrentHp = MaxHp;
  }
  public void Death(){
    SceneManager.LoadScene("end");
  }
  public void ItemUse(int ItemID){
    GameObject Item = ItemManager.returnItemObject(ItemID);
    if(InventoryManager.ReturnPieces(ItemID)>0){
      Item.GetComponent<IItem>().ItemUse();
      InventoryManager.ItemReduce(ItemID);
    }
  }
  public void WeaponEqipment(int ItemID){
    MyWeapon.GetComponent<Weapon>().Equipment(ItemID);
  }
  public void FrontMove(){
    this.transform.Translate (0,-MoveSpeed,0);
    FrontDirection();
  }
  public void BackMove(){
    this.transform.Translate (0,MoveSpeed,0);
    BackDirection();
  }
  public void RightMove(){
    this.transform.Translate (MoveSpeed,0,0);
    RightDirection();
  }
  public void LeftMove(){
    this.transform.Translate (-MoveSpeed,0,0);
    LeftDirection();
  }
  public void FrontDirection(){
    GetComponent<Animator>().SetInteger("move_direction", 0);
    Direction = 0;
  }
  public void BackDirection(){
    GetComponent<Animator>().SetInteger("move_direction", 1);
    Direction = 1;
  }
  public void RightDirection(){
    GetComponent<Animator>().SetInteger("move_direction", 2);
    Direction = 2;
  }
  public void LeftDirection(){
    GetComponent<Animator>().SetInteger("move_direction", 3);
    Direction = 3;
  }
  public void SpeedSet(int speed){
    MoveSpeed = speed ;
  }
  public void AtackKeyDown(){
    if(!AtackOn){//攻撃キーを押したか判定
      AtackOn = true;
      ChargeC = StartCoroutine(ChargeAtack());
    }
  }
  public void AtackKeyUp(){
    if(AtackOn){//攻撃キーを離したか判定
      AtackAnimation = true;
      if(ChargeEfectOn){
        ChargeEfect.GetComponent<Efect>().OnEnd();
        SpeedSet(NomalMoveSpeed);
        ChargeEfectOn = false;
      }
      MyWeapon.GetComponent<Sword>().Atack(this.Str);
      StopCoroutine(ChargeC);
    }
  }
  private IEnumerator ChargeAtack(){
    yield return new WaitForSeconds(1f);
      ChargeEfect = EfectManager.efecton("tameefect",PosX,PosY,this.gameObject);
      SpeedSet(ChargeMoveSpeed);
      ChargeEfectOn = true;
    yield return new WaitForSeconds(1f);
      ChargeEfect.GetComponent<Animator>().SetFloat("Speed", 2.0f);
      FullCharge = true;
      MyWeapon.GetComponent<Weapon>().ChargeDamageSet(this.Str);
  }
  void OnTriggerEnter2D(Collider2D collision){
    if(collision.gameObject.tag == "Item"){
      ItemGet(collision);
    }
  }
  void ItemGet(Collider2D collision){
    int getID = collision.gameObject.GetComponent<IItem>().ItemGet();
    InventoryManager.ItemGet(getID);
    collision.gameObject.GetComponent<IItem>().DropEnd();
  }


}
