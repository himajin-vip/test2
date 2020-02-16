using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullData : IData
{
    Key key;
    Value value;
    public NullData(){
        key = new Key(0);
        value = new Value(0);
    }
    public override IData Copy(){
        return new NullData();
    }
}
