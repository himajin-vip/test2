using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_ItemID_ItemBag
{
    public ItemID Get(ItemBag itemBag){
        return new Copy_ItemID().Copy(itemBag.GetID());
    }
}
