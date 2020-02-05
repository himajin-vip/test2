using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body
{
  public int ItemId{get; private set;}

  public Body(){
    ItemId = 9999;
  }
  public void Set(int itemid){
    ItemId = itemid;
    if(itemid != 9999){
      BodyItem Item = ItemManager.returnBodyItem(itemid);
      Item.Equip();
    }
    DataManager.Save();
  }

  public void UnSet(int ItemID){
      BodyItem Item = ItemManager.returnBodyItem(ItemID);
      Item.UnEquip();
      DataManager.Save();
  }
}
