using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddValue_Inventory
{
    public AddValue_Inventory(List<ItemBag> inventory ,ItemBag ItemBag){
        int index = new Get_Indexof_Inventory().ItemBagGet(inventory,ItemBag);
        inventory[index] = new AddItemBag().Add(inventory[index],ItemBag);
    }
}
