using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class IDataChecker
{
    Type IDataType;
    Type KeyType;
    Type ValueType;
    public IDataChecker(IData idata,Key key,Value value){
        IDataType = idata.GetType();
        KeyType = key.GetType();
        ValueType = value.GetType();
    }
    public bool IDataCheck(IData idata){
        if(IDataType == idata.GetType()){return true;}
        return false;
    }
    public bool KeyCheck(Key key){
        if(KeyType == key.GetType()){return true;}
        return false;
    }
    public bool ValueCheck(Value value){
        if(KeyType == value.GetType()){return true;}
        return false;
    }
    public bool KeyValueCheck(Key key,Value value){
        if(KeyType == key.GetType()&&ValueType == value.GetType()){return true;}
        return false;
    }
}
