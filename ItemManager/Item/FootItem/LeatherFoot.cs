using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherFoot : FootItem
{
  public LeatherFoot(){
    Id = 500;
    Info = "Dexを１上げます";
  }
  public override void Equip(){
    PlayerManager.Player.Dex.Equip(1);
  }
  public override void UnEquip(){
    PlayerManager.Player.Dex.UnEquip(1);
  }

}
