using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGetPeaceList : InventoryControler
{
    public List<int> Get(ItemType itemType){
        return inventoryList[itemType].GetPeaceList();
    }
}
