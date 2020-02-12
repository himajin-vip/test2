using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherBody : EquipItem
{
  public LeatherBody(){
    Id = 300;
    Info = "Vitを1上げます";
    Name = "皮の服";
    Type = ItemType.Body;
    Price = 300;
  }
  public override void Equip(Player player){
    player.Status.Vit.Equip(1);
  }
  public override void UnEquip(Player player){
    player.Status.Vit.UnEquip(1);
  }

}
