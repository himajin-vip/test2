using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBag
{
    private ItemID ItemID;
    private ItemPeace ItemPeace;

    ItemBag(int itemid, int peace){
        ItemID = new ItemID(itemid);
        ItemPeace =  new ItemPeace(peace);
    }
    public int Getid(){
        return ItemID.GetID();
    }
    public int GetPeace(){
        return ItemPeace.GetPeace();
    }
}
