using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_IntKeys_Datas
{
    public List<int> Get(List<Data> Datas){
        List<Key> keys = new Get_Keys_Datas().Get(Datas);
        return new KeysConverter().ToInts(keys); 
    }

}
