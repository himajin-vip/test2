using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory:Datas
{
    private List<Data> inventory = new List<Data>();
    private DataType DataType;
    public Inventory(DataType dataType){
        DataType = dataType;
    }
    public void Add(Data itembag){
        new DatasControler().Add(inventory,itembag,DataType);
    }
    public bool Reduce(Key itemID,Value itemPeace){
        return new DatasControler().Reduce(inventory,itemID,itemPeace,DataType);
    }
    public Value GetValue(Key itemID){
        return new DatasControler().GetValue(inventory,itemID,DataType);
    }
    // public void Load(List<Data> itemBags){
    //     new DatasControler().Load(inventory,itemBags);
    // }
    public PublicDatas GetDatas(){
        return new DatasControler().GetDatas(inventory);
    }
}
