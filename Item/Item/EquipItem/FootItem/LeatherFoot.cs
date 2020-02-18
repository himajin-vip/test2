using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherFoot : EquipItem
{
  public LeatherFoot(){
  }
  public override void Equip(Player player){
    player.Status.Dex.Equip(1);
  }
  public override void UnEquip(Player player){
    player.Status.Dex.UnEquip(1);
  }

}
