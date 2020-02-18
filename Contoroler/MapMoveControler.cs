using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoveControler : Controler
{
  Playerp Playerp;
  public MapMoveControler(){
    Playerp = GameObject.FindGameObjectWithTag("Playerp").GetComponent<Playerp>();
  }
  public void Check(){
    if(Input.GetKeyUp(KeyCode.Space)){
      Playerp.Atack.KeyUp();
    }
  }
}
