using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Indexof_Datas
{
    public int Get(List<Data> Datas ,Key key){
        List<Key> list = new Get_Keys_Datas().Get(Datas);
        for(int index = 0;index < list.Count;index++){
            if(list[index].EqualCheck(key)){
                return index;
            }
        }
        return 0;
    }
}
