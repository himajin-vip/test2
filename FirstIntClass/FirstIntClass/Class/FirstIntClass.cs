using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstIntClass
{
   protected int Value;
   protected bool Null = false;

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
