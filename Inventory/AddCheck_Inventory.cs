using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCheck_Inventory
{
    public void Check(List<ItemBag> inventory,ItemBag itembag){
        if(new HasCheck_Inventory().ItemBagCheck(inventory,itembag)){
            inventory.Add(itembag);
        }
        if(!new HasCheck_Inventory().ItemBagCheck(inventory,itembag)){
            new AddValue_Inventory(inventory,itembag);
        }
    }
}
