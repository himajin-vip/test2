using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vit
{
    public int Value{get; private set;}
    public Vit(int value){
      Value = value;
    }
    public void LvUp(int value){
      Value  += value;
    }
}
