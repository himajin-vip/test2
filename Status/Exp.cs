using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp
{
  public int currentValue{get; private set;}
  public int maxValue{get; private set;}

  public Exp(int max ,int current){
    maxValue = max;
    currentValue = current;
  }

  public void Get(int value){
    currentValue += value;
    if(currentValue >= maxValue){
      PlayerManager.Player.LvUp();
      currentValue = currentValue - maxValue;
      maxValue = (int)(maxValue * 0.1);
    }
    DataManager.Save();
  }

}
