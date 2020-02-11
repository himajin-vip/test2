using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
  public void Down(){
    if(!GameManager.Player.Atack.On){
      GameManager.Player.GameObject.transform.Translate (0,-GameManager.Player.MoveSpeed.Value,0);
      GameManager.Player.Direction.Down();
    }
  }
  public void Up(){
    if(!GameManager.Player.Atack.On){
      GameManager.Player.GameObject.transform.Translate (0,GameManager.Player.MoveSpeed.Value,0);
      GameManager.Player.Direction.Up();
    }
  }
  public void Right(){
    if(!GameManager.Player.Atack.On){
      GameManager.Player.GameObject.transform.Translate (GameManager.Player.MoveSpeed.Value,0,0);
      GameManager.Player.Direction.Right();
    }
  }
  public void Left(){
    if(!GameManager.Player.Atack.On){
      GameManager.Player.GameObject.transform.Translate (-GameManager.Player.MoveSpeed.Value,0,0);
      GameManager.Player.Direction.Left();
    }
  }

}
