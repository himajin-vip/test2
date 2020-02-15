using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reduce_IDatas
{
    public void Reduce(List<IData> IDatas ,Key key,Value value){
        if(new KeyCheck_IDatas().KeyCheck(IDatas,key)){
            int index = new Get_Indexof_IDatas().Get(IDatas,key);
            IDatas[index].Reduce(value);
            new Remove_IDatas(IDatas,key);
        }
    }
}
