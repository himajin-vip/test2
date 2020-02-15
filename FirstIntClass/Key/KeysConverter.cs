using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysConverter
{
    public List<int> ToInts(List<Key> keys){
        List<FirstIntClass> firstIntClasses = ToFirstIntClasses(keys);
        List<int> ints = new FirstintClassConvertor().Toints(firstIntClasses);
        return ints;
    }
     public List<FirstIntClass> ToFirstIntClasses(List<Key> keys){
        List<FirstIntClass> firstIntClasses = new List<FirstIntClass>();
        for(int i = 0 ; i<keys.Count;i++){
            firstIntClasses.Add(keys[i]);
        }
        return firstIntClasses;
    }
    public List<ItemID> ToItemIDs(List<Key> keys){
        List<FirstIntClass> firstIntClasses = ToFirstIntClasses(keys);
        return new FirstintClassConvertor().ToItemIDs(firstIntClasses);
    }
}
