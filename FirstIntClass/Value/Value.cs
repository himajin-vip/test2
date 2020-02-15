using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value:FirstIntClass
{

    public Value(int val = 0){
        Value = val;
        if(val == 0){
            SetNull();
        }
    }

    public void Add(Value val){
        Value += val.GetValue();
    }
    public void Reduce(Value val){
        Value -= val.GetValue();
    }
    public Value Copy(){
        return new Value(Value);
    }
}
