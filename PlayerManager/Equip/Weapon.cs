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
      ItemManager.Equip(itemid);
    }
    DataManager.Save();
  }

  public void UnSet(int ItemID){
      ItemManager.UnEquip(ItemID);
      DataManager.Save();
  }
}
