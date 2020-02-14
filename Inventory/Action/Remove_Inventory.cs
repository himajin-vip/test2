using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove_Inventory
{
    public Remove_Inventory(List<ItemBag> inventory,ItemID itemID){
        ItemPeace itemPeace = new Get_ItemPeace_Inventory().Get(inventory,itemID);
        if(new Firstint_to_Int().Get(itemPeace) == 0){
            int index = new Get_Indexof_Inventory().ItemIDGet(inventory,itemID);
            inventory.RemoveRange(index,1);
       }
    }
    
}
