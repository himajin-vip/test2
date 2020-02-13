using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryGetIDList : InventoryControler
{
    public List<int> Get(ItemType itemType){
        return inventoryList[itemType].GetIdList();
    }
}
