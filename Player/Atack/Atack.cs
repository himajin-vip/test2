using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Atack
{
  public bool On{get; private set;} = false;
  public bool KeyPush{get; private set;} = false;
  public Player Player;

  public Atack(Player player){
    Player = player;
  }
  public void KeyDown(){
    if(!On&&!KeyPush){
      if(Player.ChargeSkill.returnMp()<=Player.Status.Mp.currentValue){
        Player.Charge.Set();
      }
      KeyPush = true;
    }
  }

  public void KeyUp(){
    if(!On){
      On = true;
      Player.MoveSpeed.ReSetSpeed();
      Player.Charge.Stop();
      Player.Skill.AtackOn();
    }
    KeyPush = false;
  }

  public void Off(){
    On = false;
    Player.SetNormalAtack();
  }
}
