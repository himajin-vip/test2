using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class MenuManager
{
  private static Dictionary<string,MenuState> MenuStateList = new Dictionary<string,MenuState>();
  private static MenuState MenuState;


  public static void SetUp(){
    MenuStateList.Clear();
    MenuStateList.Add("Null",new NullState());
    MenuStateList.Add("Main",new MainState());
    MenuStateList["Main"].SetUp();
    MenuStateList.Add("Status",new StatusState());
    MenuStateList["Status"].SetUp();


    MenuState = MenuStateList["Null"];
  }

  public static void SetMenuState(string NextState){
    MenuState.End();
    MenuState = MenuStateList[NextState];
    MenuState.Start();
  }
  public static void MenuCursolMove(int direction){
    MenuState.CursolMove(direction);
  }
  public static void CursolOn(){
    MenuState.CursolOn();
  }
}
