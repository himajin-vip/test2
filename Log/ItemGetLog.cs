using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGetLog
{
    public ItemGetLog(string Name ,int ItemID){
        string newlog = (Name+"は"+ItemManager.ReturnItemName(ItemID)+"を手に入れた");
        LogManager.MakeLog(newlog);
    }
}
