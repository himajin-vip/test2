using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copy_ItemID
{
    public ItemID Copy(ItemID itemID){
        return new ItemID(itemID.GetValue());
    }
}
