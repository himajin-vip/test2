using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StatusCounter : DataCounter
{
    CharactorDatasList charactorDatasList = new CharactorDatasList();
    DataChecker DataChecker = new DataChecker(typeof(StatusData),typeof(StatusKey),typeof(StatusValue));
     public void Add(Data itemdata){
        new DataMaster().Add(charactorDatasList,itemdata,DataChecker);
    }
    public bool Reduce(Key Key,Value Value){
        return new DataMaster().Reduce(charactorDatasList,Key,Value,DataChecker);
    }
    public Value GetValue(Key Key){
       return new DataMaster().GetValue(charactorDatasList,Key,DataChecker);
    }
    // public void Load(List<List<Data>> DatasList){
    //     new DataMaster().Load(inventoryList,DatasList);
    // }
    public PublicDatasList GetDatasList(){
        return new DataMaster().GetDatasList(charactorDatasList);
    }
}
