using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
  private GameObject Object;
  private Direction Direction;

  public Move(GameObject obj,Direction direction){
    Object = obj;
    Direction = direction;
  }

  public void Down(int movespeed){
      Object.transform.Translate (0,-movespeed,0);
      Direction.Down();
  }
  public void Up(int movespeed){
      Object.transform.Translate (0,movespeed,0);
      Direction.Up();
  }
  public void Right(int movespeed){
      Object.transform.Translate (movespeed,0,0);
      Direction.Right();
  }
  public void Left(int movespeed){
      Object.transform.Translate (-movespeed,0,0);
      Direction.Left();
  }

}
