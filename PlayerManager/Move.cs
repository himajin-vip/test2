using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
  public void Down(){
    if(!PlayerManager.Player.Atack.On){
      PlayerManager.Player.GameObject.transform.Translate (0,-PlayerManager.Player.MoveSpeed.Value,0);
      PlayerManager.Player.Direction.Down();
    }
  }
  public void Up(){
    if(!PlayerManager.Player.Atack.On){
      PlayerManager.Player.GameObject.transform.Translate (0,PlayerManager.Player.MoveSpeed.Value,0);
      PlayerManager.Player.Direction.Up();
    }
  }
  public void Right(){
    if(!PlayerManager.Player.Atack.On){
      PlayerManager.Player.GameObject.transform.Translate (PlayerManager.Player.MoveSpeed.Value,0,0);
      PlayerManager.Player.Direction.Right();
    }
  }
  public void Left(){
    if(!PlayerManager.Player.Atack.On){
      PlayerManager.Player.GameObject.transform.Translate (-PlayerManager.Player.MoveSpeed.Value,0,0);
      PlayerManager.Player.Direction.Left();
    }
  }

}
