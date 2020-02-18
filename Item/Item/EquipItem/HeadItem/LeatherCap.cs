using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherCap : EquipItem
{
  public LeatherCap(){
  }
  public override void Equip(Player player){
    player.Status.Vit.Equip(1);
  }
  public override void UnEquip(Player player){
    player.Status.Vit.UnEquip(1);
  }

}
