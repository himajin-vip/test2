using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullState : MenuState
{
  public void SetUp(){}
  public void Start(){
    GameManager.StateSet("Main");
  }
  public void CursolMove(int direction){}
  public void CursolOn(){}
  public void End(){}
}
