using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullChecker
{
    protected bool Null = false;
    protected DataType DataType;

    public bool NullCheck(){
        if(Null){return true;}
        return false;
    }
    protected void SetNull(){
        Null = true;
    }
    public bool TypeNullCheck(){
        return DataType.NullCheck();
    }
}
