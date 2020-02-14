using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_ItemIDList_Inventory
{
    public List<ItemID> Get(List<ItemBag> inventory){
        List<ItemID> itemidlist = new List<ItemID>();
        for(int i = 0; i < inventory.Count;i++){
            itemidlist.Add(inventory[i].GetID());
        }
        return itemidlist;
    }
}
