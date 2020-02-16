using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryList:IDatasList
{
    public List<IDatas> inventories = new List<IDatas>();
    public ListCount listCount;
    public InventoryList(){
        listCount = new ListCountMaker().forItemType();
        inventories.Add(new Inventory(new IDataType(ItemType.Use.ToString())));
        inventories.Add(new Inventory(new IDataType(ItemType.Weapon.ToString())));
        inventories.Add(new Inventory(new IDataType(ItemType.Head.ToString())));
        inventories.Add(new Inventory(new IDataType(ItemType.Body.ToString())));
        inventories.Add(new Inventory(new IDataType(ItemType.Hand.ToString())));
        inventories.Add(new Inventory(new IDataType(ItemType.Foot.ToString())));
        inventories.Add(new Inventory(new IDataType(ItemType.Accessory.ToString())));
    }

    public void Add(IData idata){
        new IDataListsContoloer().Add(inventories,idata,listCount);
    }
    public bool Reduce(Key Key,Value Value){
        return new IDataListsContoloer().Reduce(inventories,Key,Value,listCount);
    }
    public Value GetValue(Key Key){
        return new IDataListsContoloer().GetValue(inventories,Key,listCount);
    }
    public void Load(List<List<IData>> LoadDatas){
        new IDataListsContoloer().Load(inventories,LoadDatas,listCount);
    }
    public List<List<IData>> GetIDatasList(){
       return new IDataListsContoloer().GetIDatasList(inventories,listCount);
    }

}
