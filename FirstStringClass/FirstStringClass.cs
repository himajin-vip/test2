using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStringClass
{
    protected string Value;
    public string GetValue(){
        return Value;
    }
    public bool EqualCheck(FirstStringClass firstString){
        if(Value == firstString.GetValue()){
            return true;
        }
        return false;
    }
}
