using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherCap : HeadItem
{
  public LeatherCap(){
    SetId(200);
    SetInfo("Vitを1上げます");
  }
  public override void Equip(){
    PlayerManager.Player.Vit.Equip(1);
  }
  public override void UnEquip(){
    PlayerManager.Player.Vit.UnEquip(1);
  }

}
