using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBagMaker
{
    public ItemBag Make(int key,int value,ItemType itemType){
        ItemID Key = new ItemID(key,itemType);
        return new ItemBag(Key,new ItemPeace(value));
    }
}
