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
  }
  public override void Equip(){
    PlayerManager.Player.Vit.Equip(1);
  }
  public override void UnEquip(){
    PlayerManager.Player.Vit.UnEquip(1);
  }

}
