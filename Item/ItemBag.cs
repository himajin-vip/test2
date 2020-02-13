using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBag
{
    private int ItemID;
    private int Peace;

    ItemBag(int itemid, int peace){
        ItemID = itemid;
        Peace = peace;
    }
    public int Getid(){
        return ItemID;
    }
    public int GetPeace(){
        return Peace;
    }
}
