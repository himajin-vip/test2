using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Data_Datas
{
    public Data Get(List<Data> Datas,Key key){
        int Index = new Get_Indexof_Datas().Get(Datas,key);
        return Datas[Index].Copy();
    }
}
