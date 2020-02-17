﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullData : Data
{
    Key key;
    Value value;

    public override Data Copy(){
        return new NullData();
    }
}
