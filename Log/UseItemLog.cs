using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemLog
{
    public UseItemLog(string Name,int ItemID){
        ItemLibrary itemLibrary = new ItemLibrary();
        //string newlog = (Name+"は"+itemLibrary.ReturnItemName(ItemID)+"を使った");
        //LogManager.MakeLog(newlog);
    }
}
