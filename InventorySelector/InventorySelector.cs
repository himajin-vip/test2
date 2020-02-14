using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySelector
{
    public Dictionary<ItemType,Inventory> inventories = new Dictionary<ItemType, Inventory>();
    public InventorySelector(){
        inventories.Add(ItemType.Use,new Inventory());
        inventories.Add(ItemType.Weapon,new Inventory());
        inventories.Add(ItemType.Body,new Inventory());
        inventories.Add(ItemType.Head,new Inventory());
        inventories.Add(ItemType.Hand,new Inventory());
        inventories.Add(ItemType.Foot,new Inventory());
        inventories.Add(ItemType.Accessory,new Inventory());
    }

    public void Add(ItemBag itembag){
        ItemType itemType = new Get_ItemType().forItemBag(itembag);
        inventories[itemType].Add(itembag);
    }
    public void Reduce(ItemID itemID,ItemPeace itemPeace){
        ItemType itemType = new Get_ItemType().forItemID(itemID);
        inventories[itemType].Reduce(itemID,itemPeace);
    }
    public ItemPeace GetPeace(ItemID itemID){
        ItemType itemType = new Get_ItemType().forItemID(itemID);
        return inventories[itemType].GetPeace(itemID);
    }
    public void Load(List<ItemBag> itemBags){
        if(itemBags.Count!=0){
            ItemType itemType = new Get_ItemType().forItemBag(itemBags[0]);
            inventories[itemType].Load(itemBags);
        }
    }
    public List<ItemID> GetIdList(ItemType itemType){
        return inventories[itemType].GetIdList();
    }
    public List<ItemPeace> GetPeaceList(ItemType itemType){
        return inventories[itemType].GetPeaceList();
    }

}
