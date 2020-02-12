using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordChargeAtack : Skill
{
  int Mp = 5;
  Player Player;
  GameObject PlayerObj;

  SwordChargeAtack(Player player,GameObject playerobj){
    Player = player;
    PlayerObj = playerobj;
  }
    public void Damage(Dictionary<int,Enemy> EnemyList){
      DamageCheck DamageCheck = new DamageCheck();
      foreach(Enemy enemy in EnemyList.Values){
        if(DamageCheck.Enemy(Player,enemy,2)){
          Efect Efect = new Efect();
          Efect.On("kiriefect",enemy.gameObject);
        }
      }
    }
    public int returnMp(){
      return Mp;
    }
    public void AtackOn(){
      Player.Status.Mp.Use(Mp);
      AudioManager.AudioON(5);
      int Direction = Player.Direction.Value;
      GameObject Weapon = Player.Weapon;
      Vector3 PlayerPos = PlayerObj.transform.position;
      GameObject WeaponObject;
      Animator Animator ;
        switch(Direction){
          case 0:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x+20,PlayerPos.y-32,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword0").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",0);
            WeaponObject.GetComponent<WeaponObject>().SetUp(Player);
          break;
          case 1:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x-20,PlayerPos.y+32,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword1").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",1);
            WeaponObject.GetComponent<WeaponObject>().SetUp(Player);
          break;
          case 2:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x+20,PlayerPos.y+20,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,20);
            WeaponObject.transform.Find("Sword2").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",2);
            WeaponObject.GetComponent<WeaponObject>().SetUp(Player);
          break;
          case 3:
            WeaponObject = GameManager.Instantiate(Weapon, new Vector3(PlayerPos.x-20,PlayerPos.y+20,0), Quaternion.identity);
            WeaponObject.transform.Rotate (0, 0,-20);
            WeaponObject.transform.Find("Sword3").gameObject.SetActive(true);
            Animator = WeaponObject.GetComponent<Animator>();
            Animator.SetInteger("Direction",3);
            WeaponObject.GetComponent<WeaponObject>().SetUp(Player);
          break;
        }
    }


}