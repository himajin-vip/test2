using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddValue_IDatas
{
    public AddValue_IDatas(List<IData> IDatas ,IData IData){
        int index = new Get_Indexof_IDatas().Get(IDatas,IData.GetKey());
        IDatas[index].Add(IData.GetValue());
    }
}
