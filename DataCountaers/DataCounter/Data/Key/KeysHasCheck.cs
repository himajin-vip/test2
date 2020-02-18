using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysHasCheck 
{
    public bool Check(List<Key> keys,Key key){
        for(int i = 0;i<keys.Count;i++){
            if(keys[i].EqualCheck(key)){
                return true;
            }
        }
        return false;
    }
}
