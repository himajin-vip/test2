using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
  private GameObject Object;
  private Direction Direction;
  private int movespeed;
  public Move(GameObject obj,int speed,Direction direction){
    Object = obj;
    Direction = direction;
    movespeed = speed;
  }

  public void Down(){
      Object.transform.Translate (0,-movespeed,0);
      Direction.Down();
  }
  public void Up(){
      Object.transform.Translate (0,movespeed,0);
      Direction.Up();
  }
  public void Right(){
      Object.transform.Translate (movespeed,0,0);
      Direction.Right();
  }
  public void Left(){
      Object.transform.Translate (-movespeed,0,0);
      Direction.Left();
  }

}
