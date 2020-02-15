using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControler
{
    private InventoryList inventoryList;

    public InventoryControler(){
        inventoryList = new InventoryList();
    }
     public void Add(ItemType itemType,ItemBag itembag){
        inventorySelector.Add(itemType,itembag);
    }
    public void Reduce(ItemType itemType,ItemID itemID,ItemPeace itemPeace){
        inventorySelector.Reduce(itemType,itemID,itemPeace);
    }
    public ItemPeace GetPeace(ItemType itemType,ItemID itemID){
        Value value = inventorySelector.GetValue(itemType,itemID);
        return new ItemPeace(value.GetValue());
    }
    public void Load(ItemType itemType,List<ItemBag> itemBags){
        if(itemBags.Count!=0){
            List<IData> idatas = new ItemBagConvertor().toIDatas(itemBags);
            inventorySelector.Load(itemType,idatas);
        }
    }
    public List<ItemID> GetIdList(ItemType itemType){
        List<Key> keys = inventorySelector.GetIdList(itemType);
        return new KeysConverter().ToItemIDs(keys);
    }
    public List<ItemPeace> GetPeaceList(ItemType itemType){
        List<Value> values = inventorySelector.GetPeaceList(itemType);
        return new ValuesConvertor().ToPeaces(values);
    }
}
