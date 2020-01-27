using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
  public override void Atack(){
    AtackDirection();
  }
  public override void ChargeDamageSet(int PlayerStr){
    FinalDamage = (PlayerStr+WeaponDamage)*2;
  }
}
