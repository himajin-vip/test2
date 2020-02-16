using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCounter:IDataCounter
{
    private IDatasList inventoryList;
    ItemBag itemBag;
    ItemID itemID = new ItemID(0);
    ItemPeace itemPeace;

    public InventoryCounter(){
        inventoryList = new InventoryList();
    }
     public void Add(IData IData){
         new IDataMaster().Add(inventoryList,IData);
    }
    public bool Reduce(Key Key,Value Value){
        return new IDataMaster().Reduce(inventoryList,Key,Value);
    }
    public Value GetValue(Key Key){
       return new IDataMaster().GetValue(inventoryList,Key);
    }
    public void Load(List<List<IData>> IDatasList){
        new IDataMaster().Load(inventoryList,IDatasList);
    }
    public List<List<IData>> GetIDatasList(){
        return new IDataMaster().GetIDatasList(inventoryList);
    }
}
