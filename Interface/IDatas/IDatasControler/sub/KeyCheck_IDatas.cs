using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheck_IDatas
{
    public bool KeyCheck(List<IData> IDatas,Key key){
        List<FirstIntClass> Idlist = new List<FirstIntClass>(new Get_Keys_IDatas().Get(IDatas));
        return new HasCheck_FirstintList().Check(Idlist,key);
    }
}
