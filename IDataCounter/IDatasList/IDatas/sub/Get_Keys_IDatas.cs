using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Keys_IDatas
{
    public List<Key> Get(List<IData> IDatas){
        List<Key> keys = new List<Key>();
        for(int i = 0; i < IDatas.Count;i++){
            keys.Add(IDatas[i].GetKey());
        }
        return keys;
    }
}
