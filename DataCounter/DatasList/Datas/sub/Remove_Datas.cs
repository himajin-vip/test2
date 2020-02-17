using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove_Datas
{
    public Remove_Datas(List<Data> Datas,Key key){
        Value value = new GetValue_Datas().GetValue(Datas,key);
        if(new IntClassConvertor().Toint(value) == 0){
            int index = new Get_Indexof_Datas().Get(Datas,key);
            Datas.RemoveRange(index,1);
       }
    }
    
}
