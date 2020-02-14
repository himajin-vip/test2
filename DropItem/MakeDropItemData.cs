using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDropItemData
{
    public DropItemData Make(int itemid , int itempeace , int droprate){
        ItemID itemID = new ItemID(itemid);
        ItemPeace itemPeace = new ItemPeace(itempeace);
        ItemBag itemBag = new ItemBag(itemID,itemPeace);
        DropRate dropRate = new DropRate(droprate);
        return new DropItemData(itemBag,dropRate);
    }
}
