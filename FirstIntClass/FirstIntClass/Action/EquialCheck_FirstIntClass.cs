using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquialCheck_FirstIntClass
{
   public bool Check(FirstIntClass classA,FirstIntClass classB){
       if(new Firstint_to_Int().Get(classA) == new Firstint_to_Int().Get(classB)){
           return true;
       }
       return false;
   }
}
