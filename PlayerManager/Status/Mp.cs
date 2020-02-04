using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mp
{
    public int maxValue{get; private set;}
    public int currentValue{get; private set;}

    public Mp(int max, int current){
      maxValue = max;
      currentValue = current;
    }
    public void LvUp(int value){
      maxValue  += value;
      currentValue = maxValue;
    }
}
