using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasCheck_FirstintList
{
    public bool Check(List<FirstIntClass> firstIntClasslist,FirstIntClass fechfirstintClass){
        List<int> intlist = new List<int>(new FirstintClassConvertor().Toints(firstIntClasslist));
        if(intlist.Contains(new FirstintClassConvertor().Toint(fechfirstintClass))){
            return true;
        }
        return false;
    }
}
