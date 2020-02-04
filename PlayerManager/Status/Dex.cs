using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dex
{
    public int Value{get; private set;}
    public Dex(int value){
      Value = value;
    }
    public void LvUp(int value){
      Value  += value;
    }
}
