
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weapon : MonoBehaviour
{
  public int WeaponDamage;
  public  bool WeaponHit = false;
  public int FinalDamage;

  public virtual void Atack(){
  }
  public void end(){
    transform.parent.gameObject.GetComponent<Player>().AtackOn = false;
    transform.parent.gameObject.GetComponent<Player>().AtackAnimation = false;
    WeaponHit = false;
    this.gameObject.SetActive(false);
    if(transform.parent.gameObject.GetComponent<Player>().FullCharge){
      transform.parent.gameObject.GetComponent<Player>().FullCharge = false;
    }
  }
  public virtual void ChargeDamageSet(int PlayerStr){
  }
  public virtual void NormalDamageSet(int PlayerStr){
    FinalDamage = WeaponDamage+PlayerStr;
  }

  public void Equipment(int id){
    WeaponDamage = InventoryManager.Equipment(id);
  }
  // void unEquipment();
  public void AtackDirection(){
    Debug.Log("AtackDirectionIN");
    this.gameObject.SetActive(true);
    switch(transform.parent.gameObject.GetComponent<Player>().Direction){
      case 0:
        GetComponent<Animator>().SetInteger("WeaponDirection",0);
      break;
      case 1:
        GetComponent<Animator>().SetInteger("WeaponDirection",1);
      break;
      case 2:
        GetComponent<Animator>().SetInteger("WeaponDirection",2);
      break;
      case 3:
        GetComponent<Animator>().SetInteger("WeaponDirection",3);
      break;
    }
  }
  void OnCollisionEnter2D(Collision2D collision2){//武器が当たったらダメージ
    if(collision2.gameObject.GetComponent<Enemy>()&&!WeaponHit){
      collision2.gameObject.GetComponent<Enemy>().DamageHP(FinalDamage);
      Vector3 enemypos = collision2.gameObject.transform.position;
      EfectManager.efecton("kiriefect",enemypos.x,enemypos.y,collision2.gameObject);//エフェクト作成
      if(!transform.parent.GetComponent<Player>().FullCharge){
        WeaponHit = true;
      }
    }
  }

}
