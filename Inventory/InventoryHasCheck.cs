using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryHasCheck
{
    public bool Check(ItemID itemID){
        ItemPeace itemPeace = new InventoryGetPeace().Get(itemID);
      if(itemPeace.GetValue() > 0){
        return true;
      }
      return false;
    }
}
