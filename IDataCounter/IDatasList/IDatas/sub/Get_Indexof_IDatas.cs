using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Indexof_IDatas
{
      public int Get(List<IData> IDatas ,Key key){
       List<int> list = new Get_IntKeys_IDatas().Get(IDatas);
       int intkey = key.GetValue();
       return list.IndexOf(intkey);
   }
}
