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

    public void Use(int value){
      currentValue -= value;
      DataManager.Save();
    }
    public void Recovery(int recovery){
      currentValue += recovery;
      if(currentValue>maxValue){
        currentValue = maxValue;
      }
      DataManager.Save();
    }

    public void LvUp(int value){
      maxValue  += value;
      currentValue = maxValue;
    }
}
