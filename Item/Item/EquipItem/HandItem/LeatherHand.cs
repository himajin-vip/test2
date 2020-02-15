using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherHand : EquipItem
{
  public LeatherHand(){
    Info = new ItemInfo("Dexを１上げます");
    Name = new ItemName("皮の手袋");
  }
  public override void Equip(Player player){
    player.Status.Dex.Equip(1);
  }
  public override void UnEquip(Player player){
    player.Status.Dex.UnEquip(1);
  }

}
