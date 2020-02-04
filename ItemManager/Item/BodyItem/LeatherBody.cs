using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherBody : BodyItem
{
  public LeatherBody(){
    SetId(300);
    SetInfo("Vitを5上げます");
  }
  public override void Equip(){
    PlayerManager.Player.Equip.SetVit(5);
  }
  public override void UnEquip(){
    PlayerManager.Player.Equip.SetVit(-5);
  }

}
