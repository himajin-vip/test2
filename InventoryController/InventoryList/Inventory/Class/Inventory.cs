using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory:IDatas
{
    private List<IData> inventory = new List<IData>();
    private IDataType DataType;
    public Inventory(IDataType dataType){
        DataType = dataType;
    }
    public void Add(IData itembag){
        new IDatasControler().Add(inventory,itembag,DataType);
    }
    public void Reduce(Key itemID,Value itemPeace){
        new IDatasControler().Reduce(inventory,itemID,itemPeace,DataType);
    }
    public Value GetValue(Key itemID){
        return new IDatasControler().GetValue(inventory,itemID,DataType);
    }
    public void Load(List<IData> itemBags){
        new IDatasControler().Load(inventory,itemBags);
    }
    public List<IData> GetIDatas(){
        return new IDatasControler().GetSaveData(inventory);
    }
}
