using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatasControler
{
    public void Add(List<Data> Datas,Data Data,DataType datatype){
        if(Data.EqualCheckDataType(datatype)){
            new Add_Datas().Add(Datas,Data);
        }
    }

    public bool Reduce(List<Data> Datas ,Key key,Value value,DataType dataType){
        if(key.EqualCheckDataType(dataType)){
           return new Reduce_Datas().Reduce(Datas,key,value);
        }
        return false;
    }
    public Value GetValue(List<Data> Datas ,Key key,DataType dataType){
        if(key.EqualCheckDataType(dataType)){
            return new GetValue_Datas().GetValue(Datas,key);
        }
        return new Value(0);
    }
    public void Load(List<Data> Datas, List<Data> loadData){
        Datas = loadData;
    }
    public List<Data> GetSaveData(List<Data> inventory){
        return new List<Data>(inventory);
    }
}
