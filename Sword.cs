using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
  public new void Atack(int PlayerStr){
    Debug.Log("atackin");
    FinalDamage = PlayerStr+WeaponDamage;
    AtackDirection();
  }
  public new void ChargeDamageSet(int PlayerStr){
    FinalDamage = (PlayerStr+WeaponDamage)*2;
  }
}
