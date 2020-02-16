using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_IDatas
{
    public void Add(List<IData> IDatas,IData IData){
        if(!new KeyCheck_IDatas().KeyCheck(IDatas,IData.GetKey())){
            IDatas.Add(IData);
            return;
        }
        if(new KeyCheck_IDatas().KeyCheck(IDatas,IData.GetKey())){
            new AddValue_IDatas(IDatas,IData);
        }
    }
}
