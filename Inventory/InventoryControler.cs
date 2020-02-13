using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControler
{
    protected static Dictionary<ItemType,Inventory> inventoryList = new Dictionary<ItemType, Inventory>();

    static InventoryControler(){
        inventoryList.Add(ItemType.Use,new Inventory());
        inventoryList.Add(ItemType.Weapon,new Inventory());
        inventoryList.Add(ItemType.Body,new Inventory());
        inventoryList.Add(ItemType.Head,new Inventory());
        inventoryList.Add(ItemType.Hand,new Inventory());
        inventoryList.Add(ItemType.Foot,new Inventory());
        inventoryList.Add(ItemType.Accessory,new Inventory());
    }

}
