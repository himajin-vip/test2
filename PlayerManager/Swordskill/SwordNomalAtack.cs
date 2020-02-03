using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordNomalAtack : Skill
{
    public void Damage(Dictionary<int,Enemy> EnemyList){
      foreach(Enemy enemy in EnemyList.Values){
        if(!enemy.DeathCheck){
          int AtackDamage = PlayerManager.ReturnFinalDamage();
          EfectManager.efecton("kiriefect",enemy.transform.position.x,enemy.transform.position.y,enemy.gameObject);
          if((AtackDamage-enemy.Def)>0){
            enemy.DamageHp(AtackDamage-enemy.Def);
          }else{
            enemy.DamageHp(0);
          }
          break;
        }
      }
    }

    public void AtackOn(){
      AudioManager.AudioON(2);
      int Direction = PlayerManager.ReturnDirection();
      GameObject Weapon = PlayerManager.ReturnWeapon();
      Vector3 PlayerPos = PlayerManager.ReturnPosition();
      GameObject WeaponObject;
      Animator Animator ;
        switch(Direction){
          case 0:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x+20,PlayerPos.y-32,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword0").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",0);
            WeaponObject.GetComponent<Weapon>().SetUp();
          break;
          case 1:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x-20,PlayerPos.y+32,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword1").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",1);
            WeaponObject.GetComponent<Weapon>().SetUp();
          break;
          case 2:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x+20,PlayerPos.y+20,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword2").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",2);
            WeaponObject.GetComponent<Weapon>().SetUp();
          break;
          case 3:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x-20,PlayerPos.y+20,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,-20);
            WeaponObject.transform.Find("Sword3").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",3);
            WeaponObject.GetComponent<Weapon>().SetUp();
          break;
        }

    }


}
