using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot
{
  public int ItemId{get; private set;}

  public Foot(){
    ItemId = 9999;
  }

  public void Set(int itemid){
    ItemId = itemid;
    if(itemid != 9999){
      FootItem Item = ItemManager.returnFootItem(itemid);
      Item.Equip();
    }
    DataManager.Save();
  }
  public void UnSet(int itemid){
      FootItem Item = ItemManager.returnFootItem(itemid);
      Item.UnEquip();
      DataManager.Save();
  }
}
