﻿using System.Collections;
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
    new GetExpLog(PlayerManager.Player.Name.Value,value);
    if(currentValue >= maxValue){
      PlayerManager.Player.LvUp();
      currentValue = currentValue - maxValue;
      maxValue = (int)(maxValue * 1.1);
      new LvUpLog(PlayerManager.Player.Name.Value);
      FiledText filedText = new FiledText();
      filedText.Make("LVUP",new Color(255,255,0),PlayerManager.Player.GameObject.transform);
    }
    DataManager.Save();
  }

}