using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusLv
{
  public int Value{get; private set;}
  public StatusLv(int value){
    Value = value;
  }
  public void LvUp(){
    Value++;
  }
}
