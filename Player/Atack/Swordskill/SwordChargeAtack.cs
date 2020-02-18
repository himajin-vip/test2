using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordChargeAtack
{
  int Mp = 5;
  Playerp Playerp;
  GameObject PlayerpObj;

  public SwordChargeAtack(Playerp Playerp,GameObject Playerpobj){
    // Playerp = Playerp;
    PlayerpObj = Playerpobj;
  }
    public void Damage(Dictionary<int,Enemy> EnemyList){
      DamageCheck DamageCheck = new DamageCheck();
      foreach(Enemy enemy in EnemyList.Values){
        if(DamageCheck.Enemy(Playerp,enemy,2)){
          Efect Efect = new Efect();
          Efect.On("kiriefect",enemy.gameObject);
        }
      }
    }
    public int returnMp(){
      return Mp;
    }
    public void AtackOn(){
      Playerp.Status.Mp.Use(Mp);
      new PlayAudio().Play(AudioList.ChargeAtack);
      int Direction = Playerp.Direction.Value;
      GameObject Weapon = Playerp.Weapon;
      Vector3 PlayerpPos = PlayerpObj.transform.position;
      GameObject WeaponObject;
      Animator Animator ;
        switch(Direction){
          case 0:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerpPos.x+20,PlayerpPos.y-32,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword0").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",0);
            WeaponObject.GetComponent<WeaponObject>().SetUp(Playerp);
          break;
          case 1:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerpPos.x-20,PlayerpPos.y+32,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword1").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",1);
            WeaponObject.GetComponent<WeaponObject>().SetUp(Playerp);
          break;
          case 2:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerpPos.x+20,PlayerpPos.y+20,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword2").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",2);
            WeaponObject.GetComponent<WeaponObject>().SetUp(Playerp);
          break;
          case 3:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerpPos.x-20,PlayerpPos.y+20,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,-20);
            WeaponObject.transform.Find("Sword3").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",3);
            WeaponObject.GetComponent<WeaponObject>().SetUp(Playerp);
          break;
        }
    }


}
