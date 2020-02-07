using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoveKey : Key
{
  public void Check(){
    if(Input.GetKeyUp(KeyCode.Space)){
      PlayerManager.Player.Atack.KeyUp();
    }
  }
}
