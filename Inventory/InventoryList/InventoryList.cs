using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryList:DatasList
{
    public List<Datas> inventories = new List<Datas>();
    public InventoryList(){
        foreach (ItemType Value in Enum.GetValues(typeof(ItemType))){
            inventories.Add(new Inventory(new DataType(Value.ToString())));
        }
    }

    public void Add(Data Data){
        new DataListsContoloer().Add(inventories,Data);
    }
    public bool Reduce(Key Key,Value Value){
        return new DataListsContoloer().Reduce(inventories,Key,Value);
    }
    public Value GetValue(Key Key){
        return new DataListsContoloer().GetValue(inventories,Key);
    }
    // public void Load(List<List<Data>> LoadDatas){
    //     new DataListsContoloer().Load(inventories,LoadDatas,listCount);
    // }
    public PublicDatasList GetDatasList(){
       return new DataListsContoloer().GetDatasList(inventories);
    }

}
