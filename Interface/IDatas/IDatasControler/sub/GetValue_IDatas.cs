using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetValue_IDatas
{
    public Value GetValue(List<IData> IDatas ,Key key){
        if(new KeyCheck_IDatas().KeyCheck(IDatas,key)){
            IData IData = new Get_IData_IDatas().Get(IDatas,key);
            return IData.GetValue();
        }
        return new Value();
    }
}
