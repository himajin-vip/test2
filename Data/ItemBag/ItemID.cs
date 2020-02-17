using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemID :Key
{
    public ItemID(int value = 0,ItemType itemType = ItemType.Use){
        IntValue = value;
        StringValue = value.ToString();
        DataType = new DataType(itemType.ToString());
    }
    public override Key Copy(){
        return new ItemID(IntValue,(ItemType)Enum.Parse(typeof(ItemType), DataType.GetStringValue(), true));
    }
}
