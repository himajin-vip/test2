using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Indexof_Datas
{
      public int Get(List<Data> Datas ,Key key){
       List<int> list = new Get_IntKeys_Datas().Get(Datas);
       int intkey = key.GetValue();
       return list.IndexOf(intkey);
   }
}
