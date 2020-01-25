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
  Efect ChargeEfect;
  Weapon MyWeapon;
  Animator animator;

  public void SetUp(){
    Debug.Log("Playerを初期化します");
    
    AtackAnimation = false;
    animator = GetComponent<Animator>();
    SetWeapon(100);
    PosX = 0;
    PosY = 0;
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
    UseItem Item = ItemManager.returnUseItem(ItemID);
    if(InventoryManager.ReturnPieces(ItemID)>0){
      Item.ItemUse();
      InventoryManager.ItemReduce(ItemID);
    }
  }
  public void WeaponEqipment(int ItemID){
    InventoryManager.WeaponEquipment(ItemID,MyWeapon);
  }

  public void Move(int direction){
    switch(direction){
      case 0:
        this.transform.Translate (0,-MoveSpeed,0);
        PosX = this.transform.position.x;
        PosY = this.transform.position.y;
        DirectionChenge(direction);
      break;
      case 1:
        this.transform.Translate (0,MoveSpeed,0);
        PosX = this.transform.position.x;
        PosY = this.transform.position.y;
        DirectionChenge(direction);
      break;
      case 2:
        this.transform.Translate (MoveSpeed,0,0);
        PosX = this.transform.position.x;
        PosY = this.transform.position.y;
        DirectionChenge(direction);
      break;
      case 3:
        this.transform.Translate (-MoveSpeed,0,0);
        PosX = this.transform.position.x;
        PosY = this.transform.position.y;
        DirectionChenge(direction);
      break;
    }
  }

  public void DirectionChenge(int direction){
    switch(direction){
      case 0:
        GetComponent<Animator>().SetInteger("move_direction", 0);
        Direction = 0;
      break;
      case 1:
        GetComponent<Animator>().SetInteger("move_direction", 1);
        Direction = 1;
      break;
      case 2:
        GetComponent<Animator>().SetInteger("move_direction", 2);
        Direction = 2;
      break;
      case 3:
        GetComponent<Animator>().SetInteger("move_direction", 3);
        Direction = 3;
      break;
    }
  }
  public void SpeedSet(int speed){
    MoveSpeed = speed ;
  }
  public void AtackKeyDown(){
    if(!AtackOn){//攻撃キーを押したか判定
      AtackOn = true;
      ChargeC = StartCoroutine(ChargeAtack());
      MyWeapon.NormalDamageSet(this.Str);
    }
  }
  public void AtackKeyUp(){
    if(AtackOn){//攻撃キーを離したか判定
      AtackAnimation = true;
      if(ChargeEfectOn){
        ChargeEfect.OnEnd();
        SpeedSet(NomalMoveSpeed);
        ChargeEfectOn = false;
      }
      MyWeapon.Atack();
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
      MyWeapon.ChargeDamageSet(this.Str);
  }
  void OnTriggerEnter2D(Collider2D collision){
    if(collision.gameObject.tag == "Item"){
      ItemGet(collision);
    }
  }
  void ItemGet(Collider2D collision){
    DropItem getItem = collision.gameObject.GetComponent<DropItem>();
    InventoryManager.ItemGet(getItem.ItemId);
    getItem.DropEnd();
  }
  public void SetWeapon(int ItemID){
    MyWeapon = transform.GetChild(0).gameObject.GetComponent<Weapon>();
    InventoryManager.WeaponEquipment(ItemID,MyWeapon);
  }


}
