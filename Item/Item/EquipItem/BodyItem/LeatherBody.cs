using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherBody : EquipItem
{
  public LeatherBody(){
  }
  public override void Equip(Playerp Playerp){
    Playerp.Status.Vit.Equip(1);
  }
  public override void UnEquip(Playerp Playerp){
    Playerp.Status.Vit.UnEquip(1);
  }

}
