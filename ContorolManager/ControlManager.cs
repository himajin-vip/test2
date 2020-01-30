using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  static class ControlManager
{

  public static void KeyCheck()
  {
      if(Input.GetKeyDown(KeyCode.M)){
        MenuManager.SetMenuState("Main");
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
      if(Input.GetKey(KeyCode.Space)){
        PlayerManager.AtackKeyDown();
      }
      if(Input.GetKeyUp(KeyCode.Space)){
        PlayerManager.AtackKeyUp();
      }
      if(Input.GetKeyDown(KeyCode.Alpha1)){
        ShortcutManager.ShortCutOn(1);
      }
      if(Input.GetKeyDown(KeyCode.Alpha2)){
        ShortcutManager.ShortCutOn(2);
      }
      if(Input.GetKeyDown(KeyCode.Alpha3)){
        ShortcutManager.ShortCutOn(3);
      }
      if(Input.GetKeyDown(KeyCode.Alpha4)){
        ShortcutManager.ShortCutOn(4);
      }
  }
  public static void MenuKey(){
    if(Input.GetKeyDown(KeyCode.M)){
      MenuManager.MenuOff();
    }
    if(Input.GetKeyDown(KeyCode.W)){
      MenuManager.MenuCursolMove(1);
    }
    if(Input.GetKeyDown(KeyCode.S)){
      MenuManager.MenuCursolMove(0);
    }
    if(Input.GetKeyDown(KeyCode.Space)){
      MenuManager.CursolOn();
    }
  }
  public static void AtackKeyUpCheck(){
    if(Input.GetKeyUp(KeyCode.Space)){
      PlayerManager.AtackKeyUp();
    }
  }
}
