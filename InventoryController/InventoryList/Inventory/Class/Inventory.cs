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
        if(itembag.EqualCheckDataType(DataType)){
            new IDatasControler().Add(inventory,itembag);
        }
    }
    public void Reduce(Key itemID,Value itemPeace){
        if(itemID.EqualCheckDataType(DataType)){
            new IDatasControler().Reduce(inventory,itemID,itemPeace);
        }
    }
    public Value GetValue(Key itemID){
        if(itemID.EqualCheckDataType(DataType)){
            return new IDatasControler().GetValue(inventory,itemID);
        }
        return new Value(0);
    }
    public void Load(List<IData> itemBags){
        new IDatasControler().Load(inventory,itemBags);
    }
    public List<IData> GetSaveData(){
        return new IDatasControler().GetSaveData(inventory);
    }
}
