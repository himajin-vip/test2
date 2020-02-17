using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheck_Datas
{
    public bool KeyCheck(List<Data> Datas,Key key){
        List<IntClass> Idlist = new List<IntClass>(new Get_Keys_Datas().Get(Datas));
        return new HasCheck_FirstintList().Check(Idlist,key);
    }
}
