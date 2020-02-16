using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key:FirstIntClass
{
    IDataType DataType;
    public Key(int value = 0){
        Value = value;
        if(value == 0){
            SetNull();
        }
    }
    public void Add(Key key){
        Value = Value+key.GetValue();
    }
    public Key Copy(){
        return new Key(Value);
    }
    public void SetDataType(string dataType){
        DataType = new IDataType(dataType);
    }
    public bool EqualCheckDataType(IDataType dataType){
        return DataType.EqualCheck(dataType);
    }
}
