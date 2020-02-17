using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringClass:FirstClass
{
    protected string Value;

    public override int GetIntValue(){
        return 0;
    }
    public override string GetStringValue(){
        return Value;
    }
    public bool EqualCheck(StringClass String){
        if(Value == String.GetStringValue()){return true;}
        return false;
    }
}
