using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPeaceList_to_FirstintClassList : MonoBehaviour
{

    public List<FirstIntClass> Get(List<ItemPeace> itemIDList){
        List<FirstIntClass> firstIntClasses = new List<FirstIntClass>();
        for(int i = 0 ; i<itemIDList.Count;i++){
            firstIntClasses.Add(itemIDList[i]);
        }
        return firstIntClasses;
    }
}
