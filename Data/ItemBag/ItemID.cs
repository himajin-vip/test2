using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemID :Key
{
    public ItemID(int value = 0,ItemType itemType = ItemType.Use){
        IntValue = value;
        DataType = new DataType(itemType.ToString());
    }
    public override Key Copy(){
        return new ItemID(IntValue);
    }
}
