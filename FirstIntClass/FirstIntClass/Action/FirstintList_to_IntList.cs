using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstintList_to_IntList
{
    public List<int> Get(List<FirstIntClass> firstIntList){
        List<int> intlist = new List<int>();
        for(int i = 0; i<firstIntList.Count;i++){
            int a = new Firstint_to_Int().Get(firstIntList[i]);
            intlist.Add(a);
        }
        return intlist;
    }
}
