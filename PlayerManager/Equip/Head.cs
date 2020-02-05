using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head
{
  public int ItemId{get; private set;}

  public Head(){
    ItemId = 9999;
  }

  public void Set(int itemid){
    ItemId = itemid;
    if( itemid != 9999){
      HeadItem Item = ItemManager.returnHeadItem(itemid);
      Item.Equip();
    }
    DataManager.Save();
  }

  public void UnSet(int ItemID){
      HeadItem Item = ItemManager.returnHeadItem(ItemID);
      Item.UnEquip();
      DataManager.Save();
  }
}
