using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGetPeaceList : InventoryControler
{
    public List<int> Get(ItemType itemType){
        return new List<int>(inventoryList[itemType].GetPeaceList());
    }
}
