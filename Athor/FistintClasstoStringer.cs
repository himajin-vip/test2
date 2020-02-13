using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstintClasstoStringer
{
    public string Get(FirstIntClass firstIntClass){
        string text;
        int value = firstIntClass.GetValue();
        text = value.ToString();
        return text;
    }
}
