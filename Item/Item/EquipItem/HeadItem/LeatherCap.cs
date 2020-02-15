using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherCap : EquipItem
{
  public LeatherCap(){
    Info = new ItemInfo("Vitを1上げます");
    Name = new ItemName("皮の帽子");
  }
  public override void Equip(Player player){
    player.Status.Vit.Equip(1);
  }
  public override void UnEquip(Player player){
    player.Status.Vit.UnEquip(1);
  }

}
