using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSword : WeaponItem
{
  public IronSword(){
    SetId(100);
    SetInfo("Strを10上げます");
  }
  public override void Equip(){
    PlayerManager.Player.Equip.SetStr(10);
  }
  public override void UnEquip(){
    PlayerManager.Player.Equip.SetStr(-10);
  }
}
