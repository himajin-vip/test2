using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDataMaster
{
    public void Add(IDatasList IDatasList,IData IData,IDataChecker IDataChecker){
        if(IDataChecker.IDataCheck(IData)){
            IDatasList.Add(IData);
        }
    }
    public bool Reduce(IDatasList IDatasList,Key Key,Value Value,IDataChecker IDataChecker){
        if(IDataChecker.KeyValueCheck(Key,Value)){
            return IDatasList.Reduce(Key,Value);
        }
        return false;
    }
    public Value GetValue(IDatasList IDatasList,Key Key,IDataChecker IDataChecker){
        if(IDataChecker.KeyCheck(Key)){
            return IDatasList.GetValue(Key);
        }
        return new Value();
    }
    public void Load(IDatasList IDatasList,List<List<IData>> idataslist){
        IDatasList.Load(idataslist);
    }
    public List<List<IData>> GetIDatasList(IDatasList IDatasList){
        return IDatasList.GetIDatasList();
    }
}
