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
    ItemId = itemid;
    if(itemid != 9999){
      AccessoryItem Item = ItemManager.returnAccessoryItem(itemid);
      Item.Equip();
    }
    DataManager.Save();
  }

  public void UnSet(int ItemID){
      AccessoryItem Item = ItemManager.returnAccessoryItem(ItemID);
      Item.UnEquip();
      DataManager.Save();
  }
}
