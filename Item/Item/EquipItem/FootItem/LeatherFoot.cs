using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherFoot : EquipItem
{
  public LeatherFoot(){
    Id = 500;
    Info = "Dexを１上げます";
    Name = "皮の靴";
    Type = ItemType.Foot;
    Price = 300;
  }
  public override void Equip(){
    GameManager.Player.Dex.Equip(1);
  }
  public override void UnEquip(){
    GameManager.Player.Dex.UnEquip(1);
  }

}
