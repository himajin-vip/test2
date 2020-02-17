using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetValue_Datas
{
    public Value GetValue(List<Data> Datas ,Key key){
        if(new KeyCheck_Datas().KeyCheck(Datas,key)){
            Data Data = new Get_Data_Datas().Get(Datas,key);
            return Data.GetValue();
        }
        return new Value();
    }
}
