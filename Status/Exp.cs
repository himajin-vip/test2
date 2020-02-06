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
    LogManager.GetExp(PlayerManager.Player.Name.Value,value);
    if(currentValue >= maxValue){
      PlayerManager.Player.LvUp();
      currentValue = currentValue - maxValue;
      maxValue = (int)(maxValue * 1.1);
      LogManager.LvUp(PlayerManager.Player.Name.Value);
      FiledTextManager.Make("LVUP",PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,new Color(255,255,0),PlayerManager.Player.GameObject.transform);
    }
    DataManager.Save();
  }

}
