using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copy_ItemBag
{
    public ItemBag Copy(ItemBag itemBag){
        ItemID itemID = itemBag.GetID();
        ItemPeace itemPeace = itemBag.GetPeace();
        return new ItemBag(itemID,itemPeace);
    }
}
