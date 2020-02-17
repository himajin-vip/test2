using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataMaker
{
    public ItemData MakeInfo(int itemID,string itemInfo,ItemLibrarys itemLibrarys){
        ItemID itemid =  new ItemID(itemID,itemLibrarys.ToString());
        ItemDataValue value = new ItemDataValue(0,itemInfo);
        return new ItemData(itemid,value);
    }
    public ItemData MakeName(int itemID,string itemName,ItemLibrarys itemLibrarys){
        ItemID itemid =  new ItemID(itemID,itemLibrarys.ToString());
        ItemDataValue value = new ItemDataValue(0,itemName);
        return new ItemData(itemid,value);
    }
    public ItemData MakePrice(int itemID,int Price,ItemLibrarys itemLibrarys){
        ItemID itemid =  new ItemID(itemID,itemLibrarys.ToString());
        ItemDataValue value = new ItemDataValue(Price,Price.ToString());
        return new ItemData(itemid,value);
    }
    public ItemData MakeType(int itemID,ItemType ItemType,ItemLibrarys itemLibrarys){
        ItemID itemid =  new ItemID(itemID,itemLibrarys.ToString());
        ItemDataValue value = new ItemDataValue(0,ItemType.ToString());
        return new ItemData(itemid,value);
    }

}
