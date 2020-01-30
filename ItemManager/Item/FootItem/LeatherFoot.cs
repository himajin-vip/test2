using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherFoot : FootItem
{
  public LeatherFoot(){
    SetId(500);
    SetInfo("Dexを１上げます");
  }
  public override void Equip(){
    PlayerManager.SetEquipDex(1);
  }
  public override void UnEquip(){
    PlayerManager.SetEquipDex(-1);
  }

}
