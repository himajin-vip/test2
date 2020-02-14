using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_IntPeaceList_Inventory
{
    public List<int> Get(List<ItemBag> inventory){
        List<ItemPeace> itempeaceList = new Get_ItemPeaceList_Inventory().Get(inventory);
        List<FirstIntClass> firstIntList = new ItemPeaceList_to_FirstintClassList().Get(itempeaceList); 
        return new FirstintList_to_IntList().Get(firstIntList);
    }
}
