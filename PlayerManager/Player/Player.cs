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
  public float ChargeTime;
  public bool ChargeNow;
  public bool FullCharge = false;
  public Coroutine ChargeC ;
  public Efect ChargeEfect;
  public GameObject Weapon;
  public Skill Skill;
  public Skill NormalAtack;
  public Skill ChargeSkill;

  public virtual void SetUp(){

  }

  public void SetWeapon(string name){

  }

  public void Atack(){
    if(ChargeNow){
      ChargeNow = false;
      ChargeEfect.OnEnd();
      StopCoroutine(ChargeC);
      Skill.AtackOn();
    }else{
      StopCoroutine(ChargeC);
      Skill.AtackOn();
    }
  }

  public void AtackDamageCheck(Dictionary<int,Enemy> EnemyList){
    Skill.Damage(EnemyList);
    Skill = NormalAtack;
  }

  public void ChargeStart(){
    ChargeC = StartCoroutine(Charge());
  }

  public  IEnumerator Charge(){
    yield return new WaitForSeconds(1f);
      ChargeNow = true;
      ChargeEfect = EfectManager.efecton("tameefect",transform.position.x,transform.position.y,this.gameObject);
      MoveSpeed = ChargeMoveSpeed;

    yield return new WaitForSeconds(1f);
      ChargeEfect.GetComponent<Animator>().SetFloat("Speed", 2.0f);
      Skill = ChargeSkill;
      FullCharge = true;
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
}
