using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_ItemBag_Inventory
{
    public ItemBag Get(List<ItemBag> inventory,ItemID itemID){
        if(new HasCheck_Inventory().IDCheck(inventory,itemID)){
            int Index = new Get_Indexof_Inventory().ItemIDGet(inventory,itemID);
            return new Copy_ItemBag().Copy(inventory[Index]);
        }
        return new ItemBag(new ItemID(9999),new ItemPeace(0));
    }
}
