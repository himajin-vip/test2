using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DataChecker
{
    Type KeyType;
    Type ValueType;
    public DataChecker(Type key,Type value){
        KeyType = key;
        ValueType = value;
    }
    public bool DataCheck(Data Data){
        if(Data.TypeCheck(KeyType)){return true;}
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
