using System.Collections;
using System.Collections.Generic;
using System;

public class ItemDatasList:DatasList
{
    public List<Datas> DatasList = new List<Datas>();
    public ItemDatasList(){
        foreach (DataType_ItemLibrary Value in Enum.GetValues(typeof(DataType_ItemLibrary))){
            DatasList.Add(new ItemDatas(new DataType(Value.ToString())));
        }
    }

    public void Add(Data data){
        new DataListsContoloer().Add(DatasList,data);
    }
    public bool Reduce(Key Key,Value Value){
        return false;
    }
    public Value GetValue(Key Key){
        return new DataListsContoloer().GetValue(DatasList,Key);
    }
    // public void Load(List<List<Data>> LoadDatas){
    //     new DataListsContoloer().Load(inventories,LoadDatas,listCount);
    // }
    public PublicDatasList GetDatasList(){
       return new DataListsContoloer().GetDatasList(DatasList);
    }


    
}
