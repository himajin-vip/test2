using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataListsContoloer
{
    public void Add(List<Datas> DatasList ,Data Data,ListCount listCount){
        for(int i = 0; i < listCount.GetValue();i++){
            DatasList[i].Add(Data);
        }
    }
    public bool Reduce(List<Datas> DatasList,Key Key,Value Value,ListCount listCount){
        List<bool> bools = new List<bool>();
        for(int i = 0; i < listCount.GetValue();i++){
            bools.Add(DatasList[i].Reduce(Key,Value));
        }
        return ReduceCheck(bools);
    }
    public bool ReduceCheck(List<bool> bools){
        for(int i = 0; i < bools.Count;i++){
            if(bools[i] == true){return true;}
        }
        return false;
    }
    public Value GetValue(List<Datas> DatasList,Key Key,ListCount listCount){
        for(int i = 0; i < listCount.GetValue();i++){
            Value value = DatasList[i].GetValue(Key);
            if(!value.NullCheck()){ return value; } 
        }
        return new Value(0);
    }
    public void Load(List<Datas> DatasList,List<List<Data>> LoadDatas,ListCount listCount){
        for(int i = 0;i<listCount.GetValue();i++){
            DatasList[i].Load(LoadDatas[i]);
        }
    }
    public List<List<Data>> GetDatasList(List<Datas> DatasList,ListCount listCount){
        List<List<Data>> SavaDatas = new List<List<Data>>();
        for(int i = 0;i<listCount.GetValue();i++){
            SavaDatas[i] = DatasList[i].GetDatas();
        }
        return SavaDatas;
    }
}
