using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasCheck_Inventory
{
    public bool IDCheck(List<ItemBag> inventory,ItemID itemID){
        List<FirstIntClass> Idlist = new List<FirstIntClass>(new Get_ItemIDList_Inventory().Get(inventory));
        return new HasCheck_FirstintList().Check(Idlist,itemID);
    }
    public bool ItemBagCheck(List<ItemBag> inventory,ItemBag itembag){
        List<FirstIntClass> Idlist = new List<FirstIntClass>(new Get_ItemIDList_Inventory().Get(inventory));
        ItemID itemID = itembag.GetID();
        return new HasCheck_FirstintList().Check(Idlist,itemID);
    }
}
