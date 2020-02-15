using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDatasControler
{
    public void Add(List<IData> IDatas,IData IData){
        if(new KeyCheck_IDatas().KeyCheck(IDatas,IData.GetKey())){
            IDatas.Add(IData);
        }
        if(!new KeyCheck_IDatas().KeyCheck(IDatas,IData.GetKey())){
            new AddValue_IDatas(IDatas,IData);
        }
    }
    public void Reduce(List<IData> IDatas ,Key key,Value value){
        if(new KeyCheck_IDatas().KeyCheck(IDatas,key)){
            int index = new Get_Indexof_IDatas().Get(IDatas,key);
            IDatas[index].Reduce(value);
            new Remove_IDatas(IDatas,key);
        }
    }
    public Value GetValue(List<IData> IDatas ,Key key){
        if(new KeyCheck_IDatas().KeyCheck(IDatas,key)){
            IData IData = new Get_IData_IDatas().Get(IDatas,key);
            return IData.GetValue();
        }
        return new Value();
    }
    public void Load(List<IData> IDatas, List<IData> loadData){
        IDatas = loadData;
    }
    public List<IData> GetSaveData(List<IData> inventory){
        return new List<IData>(inventory);
    }
}
