using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ShortcutManager
{
  private static GameObject ShortCut1;
  public static void SetUp(){
    ShortCut1 = GameObject.Find("ShortCut1").gameObject;
  }
  public static void ShortCutOn(int ShortCutNo){
    switch(ShortCutNo){
      case 1:
        ShortCut1.gameObject.GetComponent<ShortCut>().ItemUse();
        break;
    }
  }
  public static void update(){
    ShortCut1.GetComponent<ShortCut>().update();
  }
}
