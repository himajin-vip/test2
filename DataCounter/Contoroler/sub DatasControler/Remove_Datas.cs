using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove_Datas
{
    public Remove_Datas(List<Data> Datas,Value value ,int index){
        if(value.GetIntValue() == 0){
            Datas.RemoveRange(index,1);
       }
    }
    
}
