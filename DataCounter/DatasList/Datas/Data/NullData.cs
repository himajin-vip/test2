using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullData : Data
{
    Key key;
    Value value;
    public NullData(){
        key = new Key(0);
        value = new Value(0);
    }
    public override Data Copy(){
        return new NullData();
    }
}
