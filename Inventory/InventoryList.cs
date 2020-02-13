using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryList
{
    private Dictionary<ItemType,Inventory> List = new Dictionary<ItemType, Inventory>();
    private ItemLibrary itemLibrary = new ItemLibrary();

    public InventoryList(){
        List.Add(ItemType.Use,new Inventory());
        List.Add(ItemType.Weapon,new Inventory());
        List.Add(ItemType.Body,new Inventory());
        List.Add(ItemType.Head,new Inventory());
        List.Add(ItemType.Hand,new Inventory());
        List.Add(ItemType.Foot,new Inventory());
        List.Add(ItemType.Accessory,new Inventory());
    }

    public void Add(ItemID itemID,ItemPeace itemPeace){
        ItemType itemType = itemLibrary.GetItemType(itemID);
        List[itemType].Add(itemID,itemPeace);
    }
    public void Reduce(ItemID itemID,ItemPeace itemPeace){
        ItemType itemType = itemLibrary.GetItemType(itemID);
        List[itemType].Reduce(itemID,itemPeace);
    }
    public ItemPeace GetPeace(ItemID itemID){
        ItemType itemType = itemLibrary.GetItemType(itemID);
        return List[itemType].GetPeace(itemID);
    }
    public void Load(List<int> itemIDList, List<int> itemPeaceList){
        if(itemIDList.Count != 0){
            ItemType itemType = itemLibrary.GetItemType(new ItemID(itemIDList[0]));
            List[itemType].Load(itemIDList,itemPeaceList);
        }
    }
    public List<int> GetIdList(ItemType itemType){
        return List[itemType].GetIdList();
    }
    public List<int> GetPeaceList(ItemType itemType){
        return List[itemType].GetPeaceList();
    }

}
