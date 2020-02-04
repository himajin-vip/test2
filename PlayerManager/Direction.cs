using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction
{
  public int Value{get; private set;} = 0;
  public void Down(){
    PlayerManager.Player.Animator.SetInteger("move_direction", 0);
    Value = 0;
  }
  public void Up(){
    PlayerManager.Player.Animator.SetInteger("move_direction", 1);
    Value = 1;
  }
  public void Right(){
    PlayerManager.Player.Animator.SetInteger("move_direction", 2);
    Value = 2;
  }
  public void Left(){
    PlayerManager.Player.Animator.SetInteger("move_direction", 3);
    Value = 3;
  }
}
