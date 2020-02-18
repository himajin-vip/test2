using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPeace :Value
{
    public ItemPeace(int value = 0){
        IntValue = value;
        StringValue = value.ToString();
    }
    public override Value Copy(){
        return new ItemPeace(IntValue);
    }
}
