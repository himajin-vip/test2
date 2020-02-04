using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherHand : HandItem
{
  public LeatherHand(){
    SetId(400);
    SetInfo("Dexを１上げます");
  }
  public override void Equip(){
    PlayerManager.Player.Equip.SetDex(1);
  }
  public override void UnEquip(){
    PlayerManager.Player.Equip.SetDex(-1);
  }

}
