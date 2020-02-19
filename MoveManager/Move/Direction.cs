using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction
{
  Animator Animator;
  IntValue Value;
  public Direction(Animator animator){
    Value = new IntValue(0);
    Animator = animator;
  }
  public void Down(){
    Animator.SetInteger("Direction", 0);
    Value = new IntValue(0);
  }
  public void Up(){
    Animator.SetInteger("Direction", 1);
    Value = new IntValue(1);
  }
  public void Right(){
    Animator.SetInteger("Direction", 2);
    Value = new IntValue(2);
  }
  public void Left(){
    Animator.SetInteger("Direction", 3);
    Value = new IntValue(3);
  }
  public int Get(){
    return  Value.GetIntValue();
  }
}
