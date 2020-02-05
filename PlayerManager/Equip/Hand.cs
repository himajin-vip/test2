using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand
{
  public int ItemId{get; private set;}

  public Hand(){
    ItemId = 9999;
  }
  public void Set(int itemid){
    ItemId = itemid;
    if(itemid != 9999){
      HandItem Item = ItemManager.returnHandItem(itemid);
      Item.Equip();
    }
    DataManager.Save();
  }

  public void UnSet(int ItemID){
      HandItem Item = ItemManager.returnHandItem(ItemID);
      Item.UnEquip();
      DataManager.Save();
  }
}
