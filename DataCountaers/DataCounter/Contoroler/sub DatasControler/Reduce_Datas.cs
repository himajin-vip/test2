using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reduce_Datas
{
    public bool Reduce(List<Data> Datas ,Key key,Value value){
        if(new KeyCheck_Datas().Check(Datas,key)){
            int index = new Get_Indexof_Datas().Get(Datas,key);
            bool ReduceCheck = Datas[index].Reduce(value);
            new Remove_Datas(Datas,Datas[index].GetValue(),index);
            return ReduceCheck;
        }
        return false;
    }
}
