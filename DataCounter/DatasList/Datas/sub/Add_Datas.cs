using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_Datas
{
    public void Add(List<Data> Datas,Data Data){
        if(!new KeyCheck_Datas().KeyCheck(Datas,Data.GetKey())){
            Datas.Add(Data);
            return;
        }
        if(new KeyCheck_Datas().KeyCheck(Datas,Data.GetKey())){
            new AddValue_Datas(Datas,Data);
        }
    }
}
