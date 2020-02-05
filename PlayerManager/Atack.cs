using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Atack
{
  public bool On{get; private set;} = false;
  public bool KeyPush{get; private set;} = false;

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
