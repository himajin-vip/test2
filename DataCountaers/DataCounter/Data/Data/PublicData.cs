using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicData
{
    public string key;
    public string keytype;
    public string value;
    public PublicData(Data data){
        Key key = data.GetKey();
        Value value = data.GetValue();
        this.key = key.GetStringValue();
        this.value = value.GetStringValue();
        this.keytype = key.GetDataType();

    }
}
