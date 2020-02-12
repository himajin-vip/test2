using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherCap : EquipItem
{
  public LeatherCap(){
    Id = 200;
    Info = "Vitを1上げます";
    Name = "皮の帽子";
    Type = ItemType.Head;
    Price = 300;
  }
  public override void Equip(Player player){
    player.Status.Vit.Equip(1);
  }
  public override void UnEquip(Player player){
    player.Status.Vit.UnEquip(1);
  }

}
