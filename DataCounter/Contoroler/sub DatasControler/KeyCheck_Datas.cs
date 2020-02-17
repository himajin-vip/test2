using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheck_Datas
{
    public bool Check(List<Data> Datas,Key key){
        List<Key> keys = new List<Key>(new Get_Keys_Datas().Get(Datas));
        return new KeysHasCheck().Check(keys,key);
    }
}
