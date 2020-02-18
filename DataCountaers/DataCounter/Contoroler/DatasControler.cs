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
        if(key.EqualCheckDataType(dataType)&&new KeyCheck_Datas().Check(Datas,key)){
           return new Reduce_Datas().Reduce(Datas,key,value);
        }
        return false;
    }
    public Value GetValue(List<Data> Datas ,Key key,DataType dataType){
        if(key.EqualCheckDataType(dataType)&&new KeyCheck_Datas().Check(Datas,key)){
            return new GetValue_Datas().GetValue(Datas,key);
        }
        return new NullValue();
    }
    // public void Load(List<Data> Datas, List<Data> loadData){
    //     Datas = loadData;
    // }
    public PublicDatas GetDatas(List<Data> Datas){
        PublicDatas publicDatas = new PublicDatas();
        foreach(Data data in Datas){
            publicDatas.Add(new PublicData(data));
        }
        return publicDatas;
    }
}
