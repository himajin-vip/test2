using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValuesConvertor
{
    public List<int> ToInts(List<Value> value){
        List<FirstIntClass> firstIntClasses = ToFirstIntClasses(value);
        List<int> ints = new FirstintClassConvertor().Toints(firstIntClasses);
        return ints;
    }
     public List<FirstIntClass> ToFirstIntClasses(List<Value> values){
        List<FirstIntClass> firstIntClasses = new List<FirstIntClass>();
        for(int i = 0 ; i<values.Count;i++){
            firstIntClasses.Add(values[i]);
        }
        return firstIntClasses;
    }
    public List<ItemPeace> ToPeaces(List<Value> values){
        List<FirstIntClass> firstIntClasses = ToFirstIntClasses(values);
        return new FirstintClassConvertor().ToItemPeaces(firstIntClasses);
    }
}
