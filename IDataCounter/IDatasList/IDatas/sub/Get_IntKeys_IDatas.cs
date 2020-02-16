using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_IntKeys_IDatas
{
    public List<int> Get(List<IData> IDatas){
        List<Key> keys = new Get_Keys_IDatas().Get(IDatas);
        return new KeysConverter().ToInts(keys); 
    }

}
