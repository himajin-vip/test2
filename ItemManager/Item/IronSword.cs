using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSword : WeaponItem
{
  public override void Equip(){
    PlayerManager.SetEquipStr(5);
  }
  public override void UnEquip(){
    PlayerManager.SetEquipStr(-5);
  }
  public IronSword(){
    SetId(100);
    SetInfo("Strを5上げます");
  }
}
