using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CharactorDatasList:DatasList
{

    public List<Datas> DatasList = new List<Datas>();
    public CharactorDatasList(){
        foreach (DataType_Charactor Value in Enum.GetValues(typeof(DataType_Charactor))){
            DatasList.Add(new CharactorDatas(new DataType(Value.ToString())));
        }
    }

    public void Add(Data data){
        new DataListsContoloer().Add(DatasList,data);
    }
    public bool Reduce(Key Key,Value Value){
        return  new DataListsContoloer().Reduce(DatasList,Key,Value);
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