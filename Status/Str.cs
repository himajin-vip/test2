using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Str
{
    public int Value{get; private set;}
    public Str(int value){
      Value = value;
    }
    public void LvUp(int value){
      Value  += value;
    }
}
