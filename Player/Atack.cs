using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Atack
{
  public bool On{get; private set;} = false;
  public bool KeyPush{get; private set;} = false;

  public void KeyDown(){
    if(!On&&!KeyPush){
      if(GameManager.Player.ChargeSkill.returnMp()<=GameManager.Player.Mp.currentValue){
        GameManager.Player.Charge.Set();
      }
      KeyPush = true;
    }
  }

  public void KeyUp(){
    if(!On){
      On = true;
      GameManager.Player.MoveSpeed.ReSetSpeed();
      GameManager.Player.Charge.Stop();
      GameManager.Player.Skill.AtackOn();
    }
    KeyPush = false;
  }

  public void Off(){
    On = false;
    GameManager.Player.SetNormalAtack();
  }
}
