using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Keys_Datas
{
    public List<Key> Get(List<Data> Datas){
        List<Key> keys = new List<Key>();
        for(int i = 0; i < Datas.Count;i++){
            keys.Add(Datas[i].GetKey());
        }
        return keys;
    }
}
