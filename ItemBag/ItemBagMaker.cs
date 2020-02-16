using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBagMaker
{
    public ItemBag Make(int key,int value,ItemType itemType){
        Key Key = new Key(key);
        Key.SetDataType(itemType.ToString());
        return new ItemBag(Key,new Value(value));
    }
}
