using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusExp
{
  public int currentValue{get; private set;}
  public int maxValue{get; private set;}

  public StatusExp(int max ,int current){
    maxValue = max;
    currentValue = current;
  }

  public bool Get(int value){
    currentValue += value;
    if(currentValue >= maxValue){
      currentValue = currentValue - maxValue;
      maxValue = (int)(maxValue * 1.1);
      return true;
    }
    return false;
  }

}
