using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeed
{
  public int Value{get; private set;}
  public int ChargeSpeed{get; private set;}
  public int NomalSpeed{get; private set;}

  public MoveSpeed(int nomalspeed , int chagespeed){
    NomalSpeed = nomalspeed;
    ChargeSpeed = chagespeed;
    ReSetSpeed();
  }
  public void SetChargeSpeed(){
    Value = ChargeSpeed;
  }
  public void ReSetSpeed(){
    Value = NomalSpeed;
  }
}
