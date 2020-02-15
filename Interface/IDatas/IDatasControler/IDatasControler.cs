using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDatasControler
{
    public void Add(List<IData> IDatas,IData IData,IDataType datatype){
        if(IData.EqualCheckDataType(datatype)){
            new Add_IDatas().Add(IDatas,IData);
        }
    }

    public void Reduce(List<IData> IDatas ,Key key,Value value,IDataType dataType){
        if(key.EqualCheckDataType(dataType)){
            new Reduce_IDatas().Reduce(IDatas,key,value);
        }
    }
    public Value GetValue(List<IData> IDatas ,Key key,IDataType dataType){
        if(key.EqualCheckDataType(dataType)){
            return new GetValue_IDatas().GetValue(IDatas,key);
        }
        return new Value(0);
    }
    public void Load(List<IData> IDatas, List<IData> loadData){
        IDatas = loadData;
    }
    public List<IData> GetSaveData(List<IData> inventory){
        return new List<IData>(inventory);
    }
}
