using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPrice : Value
{
    public ItemPrice(int value,string itemLibrarys){
        IntValue = value;
        DataType = new DataType(itemLibrarys);
    }
    public override Value Copy(){
        return new ItemPrice(IntValue,DataType.GetStringValue());
    }
}
