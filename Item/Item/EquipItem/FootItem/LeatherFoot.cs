using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherFoot : EquipItem
{
  public LeatherFoot(){
    Id = new ItemID(500);
    Info = new ItemInfo("Dexを１上げます");
    Name = new ItemName("皮の靴");
    Type = ItemType.Foot;
    Price = new ItemPrice(300);
  }
  public override void Equip(Player player){
    player.Status.Dex.Equip(1);
  }
  public override void UnEquip(Player player){
    player.Status.Dex.UnEquip(1);
  }

}
