using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Data_Datas
{
    public Data Get(List<Data> Datas,Key key){
        if(Datas.Count != 0){
            int Index = new Get_Indexof_Datas().Get(Datas,key);
            Data data = Datas[Index];
            return data.Copy();
        }
        return new Data(new NullKey(),new NullValue());
    }
}
