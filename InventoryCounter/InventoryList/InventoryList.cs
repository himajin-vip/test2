using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryList:DatasList
{
    public List<Datas> inventories = new List<Datas>();
    public ListCount listCount;
    public InventoryList(){
        listCount = new ListCountMaker().forItemType();
        inventories.Add(new Inventory(new DataType(ItemType.Use.ToString())));
        inventories.Add(new Inventory(new DataType(ItemType.Weapon.ToString())));
        inventories.Add(new Inventory(new DataType(ItemType.Head.ToString())));
        inventories.Add(new Inventory(new DataType(ItemType.Body.ToString())));
        inventories.Add(new Inventory(new DataType(ItemType.Hand.ToString())));
        inventories.Add(new Inventory(new DataType(ItemType.Foot.ToString())));
        inventories.Add(new Inventory(new DataType(ItemType.Accessory.ToString())));
    }

    public void Add(Data Data){
        new DataListsContoloer().Add(inventories,Data,listCount);
    }
    public bool Reduce(Key Key,Value Value){
        return new DataListsContoloer().Reduce(inventories,Key,Value,listCount);
    }
    public Value GetValue(Key Key){
        return new DataListsContoloer().GetValue(inventories,Key,listCount);
    }
    public void Load(List<List<Data>> LoadDatas){
        new DataListsContoloer().Load(inventories,LoadDatas,listCount);
    }
    public List<List<Data>> GetDatasList(){
       return new DataListsContoloer().GetDatasList(inventories,listCount);
    }

}
