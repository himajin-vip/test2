using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ShortcutManager
{
  private static ShortCut[]　ShortcutList;
  private static int ShortCutCurrent = 1;
  public static void SetUp(){
    ShortcutList = new ShortCut[ShortCutCurrent+1];
    GameObject obj = GameObject.Find("ShortCut1").gameObject;
    ShortcutList[1] = obj.GetComponent<ShortCut>();
  }
  public static void ShortCutOn(int ShortCutNo){
    ShortcutList[ShortCutNo].ItemUse();
  }
  public static void update(){
    for(int i = 1;i < ShortCutCurrent+1;i++){
      ShortcutList[i].Reset();
    }
  }
}
