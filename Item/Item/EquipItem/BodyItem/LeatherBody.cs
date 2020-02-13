using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherBody : EquipItem
{
  public LeatherBody(){
    Id = new ItemID(300);
    Info = new ItemInfo("Vitを1上げます");
    Name = new ItemName("皮の服");
    Type = ItemType.Body;
    Price = new ItemPrice(300);
  }
  public override void Equip(Player player){
    player.Status.Vit.Equip(1);
  }
  public override void UnEquip(Player player){
    player.Status.Vit.UnEquip(1);
  }

}
