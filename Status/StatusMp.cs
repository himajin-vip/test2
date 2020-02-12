using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusMp
{
    public int maxValue{get; private set;}
    public int currentValue{get; private set;}

    public StatusMp(int max, int current){
      maxValue = max;
      currentValue = current;
    }

    public void Use(int value){
      currentValue -= value;
      GameManager.AccountData.Save();
    }
    public void Recovery(int recovery){
      currentValue += recovery;
      if(currentValue>maxValue){
        currentValue = maxValue;
      }
      GameManager.AccountData.Save();
    }

    public void LvUp(int value){
      maxValue  += value;
      currentValue = maxValue;
    }
}
