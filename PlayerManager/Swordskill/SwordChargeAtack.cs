using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordChargeAtack : Skill
{
    public void Damage(Dictionary<int,Enemy> EnemyList){
      foreach(Enemy enemy in EnemyList.Values){
        if(!enemy.DeathCheck){
          EfectManager.efecton("kiriefect",enemy.transform.position.x,enemy.transform.position.y,enemy.gameObject);
          enemy.DamageHp(PlayerManager.ReturnFinalDamage()*2);
        }
      }
    }

    public void AtackOn(){
      AudioManager.AudioON(5);
      int Direction = PlayerManager.Player.Direction.Value;
      GameObject Weapon = PlayerManager.Player.Weapon;
      Vector3 PlayerPos = PlayerManager.Player.GameObject.transform.position;
      GameObject WeaponObject;
      Animator Animator ;
        switch(Direction){
          case 0:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x+20,PlayerPos.y-32,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword0").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",0);
            WeaponObject.GetComponent<WeaponObject>().SetUp();
          break;
          case 1:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x-20,PlayerPos.y+32,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword1").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",1);
            WeaponObject.GetComponent<WeaponObject>().SetUp();
          break;
          case 2:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x+20,PlayerPos.y+20,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword2").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",2);
            WeaponObject.GetComponent<WeaponObject>().SetUp();
          break;
          case 3:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x-20,PlayerPos.y+20,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,-20);
            WeaponObject.transform.Find("Sword3").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",3);
            WeaponObject.GetComponent<WeaponObject>().SetUp();
          break;
        }
    }


}
