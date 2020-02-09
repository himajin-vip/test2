using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp
{
  public int maxValue{get; protected set;}
  public int currentValue{get; protected set;}

  public Hp(int max ,int current){
    maxValue = max;
    currentValue = current;
  }

  public void Damage(int damage){
    currentValue -= damage;
    GameManager.AccountData.Save();
  }

  public void Recovery(int recovery){
    currentValue += recovery;
    if(currentValue>maxValue){
      currentValue = maxValue;
    }
    GameManager.AccountData.Save();
  }

  public void Reset(){
    currentValue = maxValue;
  }

  public void SetMax(int maxhp){
    maxValue = maxhp;
  }
  public void SetCurrent(int currenthp){
    currentValue = currenthp;
  }
  public void LvUp(int value){
    maxValue += value;
    currentValue = maxValue;
  }

}
