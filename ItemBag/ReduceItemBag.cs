using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReduceItemBag
{
    public ItemBag Reduce(ItemBag itembagA,ItemBag itembagB){
        ItemID itemID = itembagA.GetID();
        ItemPeace itemPeaceA = itembagA.GetPeace();
        ItemPeace itemPeaceB = itembagB.GetPeace();
        int peaceA = new Firstint_to_Int().Get(itemPeaceA);
        int peaceB = new Firstint_to_Int().Get(itemPeaceB);
        ItemPeace newitemPeace = new ItemPeace(peaceA-peaceB);
        return new ItemBag(itemID,newitemPeace);
    }
}
