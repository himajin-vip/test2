using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Direction
{
  Animator Animator;
  public int Value{get; private set;} = 0;

  public Direction(Animator animator){
    Animator = animator;
  }
  public void Down(){
    Animator.SetInteger("Direction", 0);
    Value = 0;
  }
  public void Up(){
    Animator.SetInteger("Direction", 1);
    Value = 1;
  }
  public void Right(){
    Animator.SetInteger("Direction", 2);
    Value = 2;
  }
  public void Left(){
    Animator.SetInteger("Direction", 3);
    Value = 3;
  }
}
