using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullState : IMenuState
{
  public void SetUp(){}
  public void Start(){
    GameManager.SetState(GameManager.LastState);
  }
  public void CursolMove(int direction){}
  public void CursolOn(){}
  public void End(){
    GameManager.SetState("Menu");
  }
}
