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
        PlayerManager.Player.Move.Down();
      }
      if(Input.GetKey(KeyCode.W)){
        PlayerManager.Player.Move.Up();
      }
      if(Input.GetKey(KeyCode.D)){
        PlayerManager.Player.Move.Right();
      }
      if(Input.GetKey(KeyCode.A)){
        PlayerManager.Player.Move.Left();
      }
      if(Input.GetKey(KeyCode.Space)){
        PlayerManager.Player.Atack.KeyDown();
      }
      if(Input.GetKeyUp(KeyCode.Space)){
        PlayerManager.Player.Atack.KeyUp();
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
      AudioManager.AudioON(1);
    }
    if(Input.GetKeyDown(KeyCode.S)){
      MenuManager.MenuCursolMove(0);
      AudioManager.AudioON(1);
    }
    if(Input.GetKeyDown(KeyCode.Space)){
      MenuManager.CursolOn();
      AudioManager.AudioON(3);
    }
  }
  public static void TownKey(){
    if(Input.GetKeyDown(KeyCode.M)){
      MenuManager.SetMenuState("Main");
    }
    if(Input.GetKey(KeyCode.S)){
      PlayerManager.Player.Move.Down();
    }
    if(Input.GetKey(KeyCode.W)){
      PlayerManager.Player.Move.Up();
    }
    if(Input.GetKey(KeyCode.D)){
      PlayerManager.Player.Move.Right();
    }
    if(Input.GetKey(KeyCode.A)){
      PlayerManager.Player.Move.Left();
    }
    if(Input.GetKeyDown(KeyCode.Space)){
      //喋る
    }
  }
  public static void AtackKeyUpCheck(){
    if(Input.GetKeyUp(KeyCode.Space)){
      PlayerManager.Player.Atack.KeyUp();
    }
  }
}
