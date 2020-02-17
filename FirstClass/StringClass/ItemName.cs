using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemName : Value
{
    public ItemName(string value,string itemLibrarys){
        StringValue = value;
        DataType = new DataType(itemLibrarys);
    }
    public override Value Copy(){
        return new ItemName(StringValue,DataType.GetStringValue());
    }
}
