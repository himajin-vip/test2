using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherCap : HeadItem
{
  public LeatherCap(){
    SetId(200);
    SetInfo("Vitを5上げます");
  }
  public override void Equip(){
    PlayerManager.Player.Equip.SetVit(5);
  }
  public override void UnEquip(){
    PlayerManager.Player.Equip.SetVit(-5);
  }

}
