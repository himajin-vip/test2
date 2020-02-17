using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysConverter
{
    public List<int> ToInts(List<Key> keys){
        List<int> ints = new List<int>();
        for(int i =0; i < keys.Count; i++){
            ints[i] = keys[i].GetIntValue();
        }
        return ints;
    }
}
