using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
  public int ItemId{get; private set;}

  public Weapon(){
    ItemId = 9999;
  }

  public void Set(int itemid){
    ItemId = itemid;
    if(itemid != 9999){
      WeaponItem Item = ItemManager.returnWeaponItem(itemid);
      Item.Equip();
    }
    DataManager.Save();
  }

  public void UnSet(int ItemID){
      WeaponItem Item = ItemManager.returnWeaponItem(ItemID);
      Item.UnEquip();
      DataManager.Save();
  }
}
