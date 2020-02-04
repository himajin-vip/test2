using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accessory
{
  public int ItemId{get; private set;}
  public Accessory(){
    ItemId = 9999;
  }
  public void Set(int itemid){
    AccessoryItem Item = ItemManager.returnAccessoryItem(itemid);
    ItemId = itemid;
    Item.Equip();
    DataManager.Save();
  }

  static public void UnSet(int ItemID){
      AccessoryItem Item = ItemManager.returnAccessoryItem(ItemID);
      Item.UnEquip();
      DataManager.Save();
  }
}
