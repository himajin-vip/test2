using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherCap : EquipItem
{
  public LeatherCap(){
  }
  public override void Equip(Playerp Playerp){
    Playerp.Status.Vit.Equip(1);
  }
  public override void UnEquip(Playerp Playerp){
    Playerp.Status.Vit.UnEquip(1);
  }

}
