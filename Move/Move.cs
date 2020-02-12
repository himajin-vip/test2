using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
  public GameObject Object;
  public Direction Direction;
  public int movespeed;
  public Move(GameObject obj,int speed,Direction direction){
    Object = obj;
    Direction = direction;
    movespeed = speed;
  }

  public void Down(){
    if(!GameManager.Player.Atack.On){
      Object.transform.Translate (0,-movespeed,0);
      Direction.Down();
    }
  }
  public void Up(){
    if(!GameManager.Player.Atack.On){
      Object.transform.Translate (0,movespeed,0);
      Direction.Up();
    }
  }
  public void Right(){
    if(!GameManager.Player.Atack.On){
      Object.transform.Translate (movespeed,0,0);
      Direction.Right();
    }
  }
  public void Left(){
    if(!GameManager.Player.Atack.On){
      Object.transform.Translate (-movespeed,0,0);
      Direction.Left();
    }
  }

}
