using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemIDList_to_FirstintClassList
{
    public List<FirstIntClass> Get(List<ItemID> itemIDList){
        List<FirstIntClass> firstIntClasses = new List<FirstIntClass>();
        for(int i = 0 ; i<itemIDList.Count;i++){
            firstIntClasses.Add(itemIDList[i]);
        }
        return firstIntClasses;
    }
}
