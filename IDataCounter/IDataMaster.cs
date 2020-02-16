using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDataMaster
{
    public void Add(IDatasList IDatasList,IData IData){
         IDatasList.Add(IData);
    }
    public bool Reduce(IDatasList IDatasList,Key Key,Value Value){
        return IDatasList.Reduce(Key,Value);
    }
    public Value GetValue(IDatasList IDatasList,Key Key){
        return IDatasList.GetValue(Key);
    }
    public void Load(IDatasList IDatasList,List<List<IData>> idataslist){
        IDatasList.Load(idataslist);
    }
    public List<List<IData>> GetIDatasList(IDatasList IDatasList){
        return IDatasList.GetIDatasList();
    }
}
