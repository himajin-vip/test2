using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ControlManager
{
  private static Dictionary<string,Key> KeyList = new Dictionary<string,Key>();
  private static Key Key;
  static ControlManager(){
    KeyList.Add("Main",new MainKey());
    KeyList.Add("Menu",new MenuKey());
    KeyList.Add("Town",new TownKey());
    KeyList.Add("MapMove",new MapMoveKey());
  }
  public static void Check(){
    Key.Check();
  }

  public static void KeyChenge(string key){
    Key = KeyList[key];
  }
}
