using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeatherBody : BodyItem
{
  public LeatherBody(){
    SetId(300);
    SetInfo("Vitを１上げます");
  }
  public override void Equip(){
    PlayerManager.SetEquipVit(1);
  }
  public override void UnEquip(){
    PlayerManager.SetEquipVit(-1);
  }

}
