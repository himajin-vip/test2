using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_ItemPeaceList_Inventory
{
    public List<ItemPeace> Get(List<ItemBag> inventory){
        List<ItemPeace> itempeacelist = new List<ItemPeace>();
        for(int i = 0; i < inventory.Count;i++){
            itempeacelist.Add(inventory[i].GetPeace());
        }
        return itempeacelist;
    }
}
