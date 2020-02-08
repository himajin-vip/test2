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
  }
  public override void Equip(){
    PlayerManager.Player.Vit.Equip(1);
  }
  public override void UnEquip(){
    PlayerManager.Player.Vit.UnEquip(1);
  }

}
