﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  static class ControlManager
{

  public static void KeyCheck()
  {
    Debug.Log(PlayerManager.Player.AtackAnimation);
    if(!PlayerManager.Player.AtackAnimation){
      Debug.Log("KeyCheck");
      if(Input.GetKeyDown(KeyCode.M)){
        UI_Manager.MenuOn();
      }
      if(Input.GetKey(KeyCode.S)){
        PlayerManager.PlayerMove(0);
      }
      if(Input.GetKey(KeyCode.W)){
        PlayerManager.PlayerMove(1);
      }
      if(Input.GetKey(KeyCode.D)){
        PlayerManager.PlayerMove(2);
      }
      if(Input.GetKey(KeyCode.A)){
        PlayerManager.PlayerMove(3);
      }
      if(Input.GetKeyDown(KeyCode.Space)){
        PlayerManager.Player.GetComponent<Player>().AtackKeyDown();
      }
      if(Input.GetKeyUp(KeyCode.Space)){
        PlayerManager.Player.GetComponent<Player>().AtackKeyUp();
      }
      if(Input.GetKeyDown(KeyCode.U)){
        ShortcutManager.ShortCutOn(1);
      }
    }
  }
}
