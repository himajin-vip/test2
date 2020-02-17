using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData　:　Data
{
    public ItemData(Key key , Value value){
        Key = key;
        Value = value; 
    }
    public override Data Copy(){
        return new ItemData(Key.Copy(),Value.Copy());
    }     
}
