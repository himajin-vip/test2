using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysConverter
{
    public List<int> ToInts(List<Key> keys){
        List<int> ints = new List<int>();
        for(int i =0; i < keys.Count; i++){
            int j = keys[i].GetIntValue();
            ints.Add (j);
        }
        return ints;
    }
}
