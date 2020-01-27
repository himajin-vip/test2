using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  public string Name;
  public int Lv;
  public int MaxHp;
  public int CurrentHp;
  public int MaxMp;
  public int CurrentMp;
  public int Str;
  public int Vit;
  public int Dex;
  public int Int;
  public int NextExp;
  public int CurrentExp;
  public int MoveSpeed;
  public int Direction;
  public int ChargeMoveSpeed;
  public int NomalMoveSpeed;
  public bool AtackAnimation = false;
  public bool AtackOn = false;
  public bool ChargeEfectOn = false;
  public bool FullCharge = false;
  public bool KeyUp = false;
  public Coroutine ChargeC ;
  public Efect ChargeEfect;
  public Weapon MyWeapon;
  public Animator animator;

  public virtual void SetUp(){

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
      ChargeEfect = EfectManager.efecton("tameefect",transform.position.x,transform.position.y,this.gameObject);
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
    LogManager.MakeItemGetLog(Name,getItem.ItemId);
    getItem.DropEnd();
  }
  public void SetWeapon(int ItemID){
    MyWeapon = transform.GetChild(0).gameObject.GetComponent<Weapon>();
    InventoryManager.WeaponEquipment(ItemID,MyWeapon);
  }


}
