using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMaster
{
    public void Add(DatasList DatasList,Data Data,DataChecker DataChecker){
        if(DataChecker.DataCheck(Data)){
            DatasList.Add(Data);
        }
    }
    public bool Reduce(DatasList DatasList,Key Key,Value Value,DataChecker DataChecker){
        if(DataChecker.KeyValueCheck(Key,Value)){
            return DatasList.Reduce(Key,Value);
        }
        return false;
    }
    public Value GetValue(DatasList DatasList,Key Key,DataChecker DataChecker){
        if(DataChecker.KeyCheck(Key)){
            return DatasList.GetValue(Key);
        }
        return new NullValue();
    }
    // public void Load(DatasList DatasList,List<List<Data>> Dataslist){
    //     DatasList.Load(Dataslist);
    // }
    // public List<List<Data>> GetDatasList(DatasList DatasList){
    //     return DatasList.GetDatasList();
    // }
}
