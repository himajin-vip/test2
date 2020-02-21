using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Value:FirstClass
{
    protected string StringValue;
    protected int IntValue;

    public override int GetIntValue(){
        return IntValue;
    }
    public override string GetStringValue(){
        return StringValue;
    }

    public void Add(Value val){
        IntValue += val.GetIntValue();
    }
    public virtual bool Reduce(Value val){
        if(ReduceCheck(val)){
            IntValue -= val.GetIntValue();
            return true;
        }
        return false;
    }
    public bool ReduceCheck(Value val){
        if(IntValue >= val.GetIntValue()){
            return true;
        }
        return false;
    }
    public abstract Value Copy();
}
