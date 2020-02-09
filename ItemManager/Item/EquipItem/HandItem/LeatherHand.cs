using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherHand : EquipItem
{
  public LeatherHand(){
    Id = 400;
    Info = "Dexを１上げます";
    Name = "皮の手袋";
    Type = ItemType.Hand;
  }
  public override void Equip(){
    GameManager.Player.Dex.Equip(1);
  }
  public override void UnEquip(){
    GameManager.Player.Dex.UnEquip(1);
  }

}
