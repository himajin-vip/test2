using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualCheck_ItemID_ItemBag
{
    public bool Check(ItemBag itembagA, ItemBag itembagB){
        ItemID itemidA = itembagA.GetID();
        ItemID itemidB = itembagB.GetID();
        if(new EquialCheck_FirstIntClass().Check(itemidA,itemidB)){
            return true;
        }
        return false;
    }
}
