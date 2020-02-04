using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Int
{
    public int Value{get; private set;}
    public Int(int value){
      Value = value;
    }
    public void LvUp(int value){
      Value  += value;
    }
}
