using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<ItemBag> inventory = new List<ItemBag>();

    public void Add(ItemBag itembag){
       new AddCheck_Inventory().Check(inventory ,itembag);
    }
    public void Reduce(ItemID itemID,ItemPeace itemPeace){
        new ReduceValue_for_Inventory(inventory,new ItemBag(itemID,itemPeace));
    }
    public ItemPeace GetPeace(ItemID itemID){
        return new Get_ItemPeace_Inventory().Get(inventory,itemID);
    }
    public void Load(List<ItemBag> itemBags){
        inventory = new List<ItemBag>(itemBags);
    }
    public List<ItemID> GetIdList(){
        return new List<ItemID>(new Get_ItemIDList_Inventory().Get(inventory));
    }
    public List<ItemPeace> GetPeaceList(){
        return new Get_ItemPeaceList_Inventory().Get(inventory);
    }
}
