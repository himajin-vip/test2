using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddValue_Datas
{
    public AddValue_Datas(List<Data> Datas ,Data Data){
        int index = new Get_Indexof_Datas().Get(Datas,Data.GetKey());
        Datas[index].Add(Data.GetValue());
    }
}
