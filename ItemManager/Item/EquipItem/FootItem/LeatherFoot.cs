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
  }
  public override void Equip(){
    PlayerManager.Player.Dex.Equip(1);
  }
  public override void UnEquip(){
    PlayerManager.Player.Dex.UnEquip(1);
  }

}
