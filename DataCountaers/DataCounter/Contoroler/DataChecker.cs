using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DataChecker
{
    protected List<DataType> DataTypes = new List<DataType>();
    public bool DataCheck(Data Data){
        foreach(DataType datatype in DataTypes){
            if(Data.EqualCheckDataType(datatype)){
                return true;
            }
        }
        return false;
    }
    public bool KeyCheck(Key key){
        foreach(DataType datatype in DataTypes){
            if(key.EqualCheckDataType(datatype)){
                return true;
            }
        }
        return false;
    }
}
