using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Atack
{
  public bool On{get; private set;} = false;
  public bool KeyPush{get; private set;} = false;
  public Playerp Playerp;

  public Atack(Playerp Playerp){
    // Playerp = Playerp;
  }
  public void KeyDown(){
    // if(!On&&!KeyPush){
    //   // if(Playerp.ChargeSkill.returnMp()<=Playerp.Status.Mp.currentValue){
    //     Playerp.Charge.Set();
    //   }
    //   KeyPush = true;
    // }
  }

  public void KeyUp(){
    if(!On){
      On = true;
      Playerp.MoveSpeed.ReSetSpeed();
      Playerp.Charge.Stop();
      // Playerp.Skill.AtackOn();
    }
    KeyPush = false;
  }

  public void Off(){
    On = false;
    Playerp.SetNormalAtack();
  }
}
