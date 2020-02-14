using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceValue_for_Inventory : MonoBehaviour
{
    public ReduceValue_for_Inventory(List<ItemBag> inventory ,ItemBag ItemBag){
        if(new HasCheck_Inventory().ItemBagCheck(inventory,ItemBag)){
            int index = new Get_Indexof_Inventory().ItemBagGet(inventory,ItemBag);
            inventory[index] = new ReduceItemBag().Reduce(inventory[index],ItemBag);
            new Remove_Inventory(inventory,ItemBag.GetID());
        }
    }
}
