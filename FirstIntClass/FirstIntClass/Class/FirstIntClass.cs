using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstIntClass
{
   public int Value;
   public bool Null = false;

   public int GetValue(){
       return Value;
   }
   public bool NullCheck(){
       return Null;
   }
   protected void SetNull(){
       Null = true;
   }
}
