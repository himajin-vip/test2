using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atack
{
  public bool On{get; private set;} = false;
  public bool KeyPush{get; private set;} = false;


  public int ReturnFinalDamage(){
    int Damage = 0;
    int DamageDice1 = 0;
    int DamageDice2 = 0;
    int ExDamage = (PlayerManager.Player.Str.Value+PlayerManager.Player.Equip.Str)/10;
    for(int i = 0; i <= 0+ExDamage ; i++){
      DamageDice1 = Random.Range(0,7);
      DamageDice2 = Random.Range(0,7);
      if(DamageDice1+DamageDice2 == 12){
        i--;
      }
      Damage += (DamageDice1+DamageDice2)/2;
    }

    return Damage;
  }

  public void KeyDown(){
    if(!On&&!KeyPush){
      PlayerManager.Player.Charge.Set();
      KeyPush = true;
    }
  }

  public void KeyUp(){
    if(!On){
      On = true;
      PlayerManager.Player.MoveSpeed.ReSetSpeed();
      PlayerManager.Player.Charge.Stop();
      PlayerManager.Player.Skill.AtackOn();
    }
    KeyPush = false;
  }

  public void Off(){
    On = false;
    PlayerManager.Player.SetNormalAtack();
  }
}
