using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasCheck_FirstintList
{
    public bool Check(List<FirstIntClass> firstIntClasslist,FirstIntClass fechfirstintClass){
        List<int> intlist = new List<int>(new FirstintList_to_IntList().Get(firstIntClasslist));
        if(intlist.Contains(new Firstint_to_Int().Get(fechfirstintClass))){
            return true;
        }
        return false;
    }
}
