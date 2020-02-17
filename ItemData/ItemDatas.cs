using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatas:Datas
{
    private List<Data> Datas = new List<Data>();
    private DataType DataType;
    public ItemDatas(DataType dataType){
        DataType = dataType;
    }
    public void Add(Data data){
        new DatasControler().Add(Datas,data,DataType);
    }
    public bool Reduce(Key key,Value value){
        return false;
    }
    public Value GetValue(Key itemID){
        return new DatasControler().GetValue(Datas,itemID,DataType);
    }
    // public void Load(List<Data> itemBags){
    //     new DatasControler().Load(inventory,itemBags);
    // }
    public PublicDatas GetDatas(){
        return new DatasControler().GetDatas(Datas);
    }
}
