using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCounter:DataCounter
{
    private DatasList inventoryList;
    private DataChecker DataChecker;

    public InventoryCounter(){
        inventoryList = new InventoryList();
        DataChecker = new DataChecker(new ItemBagMaker().Make(0,0,ItemType.Use),new ItemID(),new ItemPeace());
    }
     public void Add(Data Data){
         new DataMaster().Add(inventoryList,Data,DataChecker);
    }
    public bool Reduce(Key Key,Value Value){
        return new DataMaster().Reduce(inventoryList,Key,Value,DataChecker);
    }
    public Value GetValue(Key Key){
       return new DataMaster().GetValue(inventoryList,Key,DataChecker);
    }
    public void Load(List<List<Data>> DatasList){
        new DataMaster().Load(inventoryList,DatasList);
    }
    public List<List<Data>> GetDatasList(){
        return new DataMaster().GetDatasList(inventoryList);
    }
}
