using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDataListsContoloer
{
    public void Add(List<IDatas> IDatasList ,IData idata,ListCount listCount){
        for(int i = 0; i < listCount.GetValue();i++){
            IDatasList[i].Add(idata);
        }
    }
    public void Reduce(List<IDatas> IDatasList,Key Key,Value Value,ListCount listCount){
        for(int i = 0; i < listCount.GetValue();i++){
            IDatasList[i].Reduce(Key,Value);
        }
    }
    public Value GetValue(List<IDatas> IDatasList,Key Key,ListCount listCount){
        for(int i = 0; i < listCount.GetValue();i++){
            Value value = IDatasList[i].GetValue(Key);
            if(value.NullCheck()){
                return value;
            } 
        }
        return new Value(0);
    }
    public void Load(List<IDatas> IDatasList,List<List<IData>> LoadDatas,ListCount listCount){
        for(int i = 0;i<listCount.GetValue();i++){
            IDatasList[i].Load(LoadDatas[i]);
        }
    }
    public List<List<IData>> GetIDatasList(List<IDatas> IDatasList,ListCount listCount){
        List<List<IData>> SavaDatas = new List<List<IData>>();
        for(int i = 0;i<listCount.GetValue();i++){
            SavaDatas[i] = IDatasList[i].GetIDatas();
        }
        return SavaDatas;
    }
}
