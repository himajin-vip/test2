using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCounter:IDataCounter
{
    private IDatasList inventoryList;
    private IDataChecker IDataChecker;

    public InventoryCounter(){
        inventoryList = new InventoryList();
        IDataChecker = new IDataChecker(new ItemBagMaker().Make(0,0,ItemType.Use),new ItemID(),new ItemPeace());
    }
     public void Add(IData IData){
         new IDataMaster().Add(inventoryList,IData,IDataChecker);
    }
    public bool Reduce(Key Key,Value Value){
        return new IDataMaster().Reduce(inventoryList,Key,Value,IDataChecker);
    }
    public Value GetValue(Key Key){
       return new IDataMaster().GetValue(inventoryList,Key,IDataChecker);
    }
    public void Load(List<List<IData>> IDatasList){
        new IDataMaster().Load(inventoryList,IDatasList);
    }
    public List<List<IData>> GetIDatasList(){
        return new IDataMaster().GetIDatasList(inventoryList);
    }
}
