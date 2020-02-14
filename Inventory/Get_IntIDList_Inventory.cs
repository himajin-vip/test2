using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_IntIDList_Inventory
{
    public List<int> Get(List<ItemBag> inventory){
        List<ItemID> itemIDList = new Get_ItemIDList_Inventory().Get(inventory);
        List<FirstIntClass> firstIntList = new ItemIDList_to_FirstintClassList().Get(itemIDList); 
        return new FirstintList_to_IntList().Get(firstIntList);
    }

}
