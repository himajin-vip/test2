using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemID :Key
{
    public ItemID(int value = 0,string dataType = ""){
        IntValue = value;
        StringValue = value.ToString();
        DataType = new DataType(dataType);
    }
    public override Key Copy(){
        return new ItemID(IntValue,DataType.GetStringValue());
    }
}
