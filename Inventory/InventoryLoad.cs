using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryLoad : InventoryControler
{
    public void Load(List<int> itemIDList, List<int> itemPeaceList){
        if(itemIDList.Count != 0){
            ItemType itemType = new GetItemType().Get(new ItemID(itemIDList[0]));
            inventoryList[itemType].Load(itemIDList,itemPeaceList);
        }
    }

}
