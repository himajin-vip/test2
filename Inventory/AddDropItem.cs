using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDropItem
{
    public void Add(ItemBag itemBag){
        new InventoryAdd().Add(itemBag);
    }

}
