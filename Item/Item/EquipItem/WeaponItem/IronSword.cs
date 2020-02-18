using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSword : EquipItem
{
  public IronSword(){
  }
  public override void Equip(Player player){
    player.Status.Str.Equip(5);
  }
  public override void UnEquip(Player player){
    player.Status.Str.UnEquip(5);
  }
}
