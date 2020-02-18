
using System.Collections.Generic;
using UnityEngine;
public class ItemLibrary:DataCounter
{

    private DatasList itemLibrary;
    private DataChecker DataChecker;

    public ItemLibrary(){
        itemLibrary = new ItemDatasList();
        DataChecker = new ItemLibraryChecker();
    }
     public void Add(Data itemdata){
        new DataMaster().Add(itemLibrary,itemdata,DataChecker);
    }
    public bool Reduce(Key Key,Value Value){
        return false;
    }
    public Value GetValue(Key Key){
       return new DataMaster().GetValue(itemLibrary,Key,DataChecker);
    }
    // public void Load(List<List<Data>> DatasList){
    //     new DataMaster().Load(inventoryList,DatasList);
    // }
    public PublicDatasList GetDatasList(){
        return new DataMaster().GetDatasList(itemLibrary);
    }

}
