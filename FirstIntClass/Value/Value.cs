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
    public bool Reduce(Value val){
        if(ReduceCheck(val)){
            Value -= val.GetValue();
            return true;
        }
        return false;
    }
    public bool ReduceCheck(Value val){
        if(Value >= val.GetValue()){
            return true;
        }
        return false;
    }
    public Value Copy(){
        return new Value(Value);
    }
}
