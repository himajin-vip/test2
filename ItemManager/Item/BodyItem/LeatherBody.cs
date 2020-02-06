﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherBody : BodyItem
{
  public LeatherBody(){
    SetId(300);
    SetInfo("Vitを1上げます");
  }
  public override void Equip(){
    PlayerManager.Player.Vit.Equip(1);
  }
  public override void UnEquip(){
    PlayerManager.Player.Vit.UnEquip(1);
  }

}
