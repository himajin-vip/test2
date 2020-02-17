using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class IntClass:FirstClass
{
    protected int Value;
    public override int GetIntValue(){
        return Value;
    }
    public override string GetStringValue(){
        return Value.ToString();
    }
}
