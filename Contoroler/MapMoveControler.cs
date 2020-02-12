using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoveControler : Controler
{
  Player Player;
  public MapMoveControler(){
    Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
  }
  public void Check(){
    if(Input.GetKeyUp(KeyCode.Space)){
      Player.Atack.KeyUp();
    }
  }
}
