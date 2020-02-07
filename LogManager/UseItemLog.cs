using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemLog
{
    public UseItemLog(string Name,int ItemID){
        string newlog = (Name+"は"+ItemManager.returnItemName(ItemID)+"を使った");
        LogManager.MakeLog(newlog);
    }
}
