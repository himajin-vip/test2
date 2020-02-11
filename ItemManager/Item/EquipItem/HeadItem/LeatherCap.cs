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
  public override void Equip(){
    GameManager.Player.Vit.Equip(1);
  }
  public override void UnEquip(){
    GameManager.Player.Vit.UnEquip(1);
  }

}
