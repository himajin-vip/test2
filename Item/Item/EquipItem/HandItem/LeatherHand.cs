using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherHand : EquipItem
{
  public LeatherHand(){
  }
  public override void Equip(Playerp Playerp){
    Playerp.Status.Dex.Equip(1);
  }
  public override void UnEquip(Playerp Playerp){
    Playerp.Status.Dex.UnEquip(1);
  }

}
