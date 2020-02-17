using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : Value
{
    public ItemInfo(string value,string itemLibrarys){
        StringValue = value;
        DataType = new DataType(itemLibrarys);
    }
    public override Value Copy(){
        return new ItemInfo(StringValue,DataType.GetStringValue());
    }
}
