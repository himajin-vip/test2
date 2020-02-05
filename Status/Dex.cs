using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dex
{
  public int Value{get; private set;}
  public int NomalValue{get; private set;}
  private int ExValue;
  private int EquipValue;
  public Dex(int value){
    NomalValue = value;
    Value = NomalValue + ExValue + EquipValue;
  }
  public void Add(int exvalue){
    ExValue += exvalue;
    Value = NomalValue + ExValue + EquipValue;
  }
  public void Remove(int removevalue){
    ExValue -= removevalue;
    Value = NomalValue + ExValue + EquipValue;
  }
  public void Equip(int value){
    EquipValue += value;
    Value = NomalValue + ExValue + EquipValue;
  }
  public void UnEquip(int value){
    EquipValue -= value;
    Value = NomalValue + ExValue + EquipValue;
  }
    public void LvUp(int value){
      Value  += value;
    }
}
