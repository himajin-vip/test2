using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData
{
    ItemID itemID;
    ItemPrice itemPrice;
    public ItemData(ItemID itemid,ItemPrice itemprice){
        itemID = itemid;
        itemPrice = itemprice;
    }
    public ItemID GetID(){
        return itemID;
    }
    public ItemPrice GetPrice(){
        return itemPrice;
    }
}
