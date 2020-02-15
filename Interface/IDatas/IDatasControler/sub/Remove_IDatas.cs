using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove_IDatas
{
    public Remove_IDatas(List<IData> IDatas,Key key){
        Value value = new IDatasControler().GetValue(IDatas,key);
        if(new FirstintClassConvertor().Toint(value) == 0){
            int index = new Get_Indexof_IDatas().Get(IDatas,key);
            IDatas.RemoveRange(index,1);
       }
    }
    
}
