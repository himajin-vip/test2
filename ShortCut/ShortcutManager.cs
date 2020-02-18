using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortcutManager
{
  private static Dictionary<int,ShortCut> ShortcutList = new Dictionary<int,ShortCut>();
  private static Playerp Playerp;
  private static bool[] SetOK;

  public void SetUp(){
    ShortcutList.Clear();
    SetOK = new bool[5];
    ShortcutList.Add(1,GameObject.Find("ShortCut1").GetComponent<ShortCut>());
    ShortcutList[1].SetUp();
    SetOK[1]=false;
    ShortcutList.Add(2,GameObject.Find("ShortCut2").GetComponent<ShortCut>());
    ShortcutList[2].SetUp();
    SetOK[2]=false;
    ShortcutList.Add(3,GameObject.Find("ShortCut3").GetComponent<ShortCut>());
    ShortcutList[3].SetUp();
    SetOK[3]=false;
    ShortcutList.Add(4,GameObject.Find("ShortCut4").GetComponent<ShortCut>());
    ShortcutList[4].SetUp();
    SetOK[4]=false;

    Playerp = GameObject.FindGameObjectWithTag("Playerp").GetComponent<Playerp>();
  }


  public static void ShortCutOn(int ShortcutNo){
    if(SetOK[ShortcutNo]){
      // Playerp.ItemUse(new ItemID(ShortcutList[ShortcutNo].IDShortcut));
    }
  }

  public static void AllPiecesReset(){
    for(int i=1; i<=4 ; i++){
      if(SetOK[i]){
        ShortcutList[i].PiecesReset();
      }
    }
  }

  public static void SetShortcut(int ShortcutNo,int ItemID){
    ShortcutList[ShortcutNo].SetId(ItemID);
    SetOK[ShortcutNo] = true;
  }
}
