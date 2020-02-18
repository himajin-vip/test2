using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DataChecker
{
    Type DataType;
    Type KeyType;
    Type ValueType;
    public DataChecker(Type Data,Type key,Type value){
        DataType = Data;
        KeyType = key;
        ValueType = value;
    }
    public bool DataCheck(Data Data){
        if(DataType == Data.GetType()){return true;}
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
