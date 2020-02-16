using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_IData_IDatas
{
    public IData Get(List<IData> IDatas,Key key){
        if(new KeyCheck_IDatas().KeyCheck(IDatas,key)){
            int Index = new Get_Indexof_IDatas().Get(IDatas,key);
            return IDatas[Index].Copy();
        }
        return new NullData();
    }
}
