using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataValue : Value
{
    public ItemDataValue(int intval,string value){
        StringValue = value;
        IntValue = intval;
    }
    public override Value Copy(){
        return new ItemDataValue(IntValue,StringValue);
    }
}
