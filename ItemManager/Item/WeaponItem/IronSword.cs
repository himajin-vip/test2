using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSword : WeaponItem
{
  public IronSword(){
    SetId(100);
    SetInfo("Strを5上げます");
  }
  public override void Equip(){
    PlayerManager.Player.Str.Equip(5);
  }
  public override void UnEquip(){
    PlayerManager.Player.Str.UnEquip(5);
  }
}
