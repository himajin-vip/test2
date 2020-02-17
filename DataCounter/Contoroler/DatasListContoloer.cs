using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataListsContoloer
{
    public void Add(List<Datas> DatasList ,Data Data){
        foreach(Datas datas in DatasList){
            datas.Add(Data);
        }
    }
    public bool Reduce(List<Datas> DatasList,Key Key,Value Value){
        List<bool> bools = new List<bool>();
        foreach(Datas datas in DatasList){
            bools.Add(datas.Reduce(Key,Value));
        }
        return ReduceCheck(bools);
    }
    public bool ReduceCheck(List<bool> bools){
        for(int i = 0; i < bools.Count;i++){
            if(bools[i] == true){return true;}
        }
        return false;
    }
    public Value GetValue(List<Datas> DatasList,Key Key){
        foreach(Datas datas in DatasList){
            Value value = datas.GetValue(Key);
            if(!value.NullCheck()){ return value; } 
        }
        return new NullValue();
    }
    // public void Load(List<Datas> DatasList,List<List<Data>> LoadDatas,ListCount listCount){
    //     for(int i = 0;i<listCount.GetIntValue();i++){
    //         DatasList[i].Load(LoadDatas[i]);
    //     }
    // }
    public PublicDatasList GetDatasList(List<Datas> DatasList){
        PublicDatasList publicDatasList = new PublicDatasList();
        foreach(Datas datas in DatasList){
            publicDatasList.Add(datas.GetDatas());
        }
        return publicDatasList;
    }
}
