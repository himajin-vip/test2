using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Key:FirstClass
{
    protected string StringValue;
    protected int IntValue;
    public override int GetIntValue(){
        return IntValue;
    }
    public override string GetStringValue(){
        return StringValue;
    }  

    public Key(int value = 0,string str = ""){
        IntValue = value;
        StringValue = str;
        if(value == 0&&str == "0"){
            SetNull();
        }
    }
    public abstract Key Copy();
    public bool EqualCheck(Key key){
        if(StringValue == key.GetStringValue()&&IntValue == GetIntValue()){
            return true;
        }
        return false;
    }
    private void SetDataType(string dataType){
        DataType = new DataType(dataType);
    }
    public bool EqualCheckDataType(DataType dataType){
        return DataType.EqualCheck(dataType);
    }
    public string GetDataType(){
        return DataType.GetStringValue();
    }
}
