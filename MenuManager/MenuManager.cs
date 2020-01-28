using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class MenuManager
{
  private static Dictionary<string,MenuState> MenuStateList = new Dictionary<string,MenuState>();
  private static MenuState MenuState;
  private static GameObject MenuCanvas;
  private static GameObject MainMenuPanel;
  private static GameObject StatusPanel;
  private static GameObject InventoryPanel;


  public static void SetUp(){
    MenuStateList.Clear();
    MenuCanvas = GameObject.Find("MenuCanvas").gameObject;
    MainMenuPanel = MenuCanvas.transform.Find("MainMenuPanel");
    StatusPanel = MenuCanvas.transform.Find("StatusPanel");




    MenuStateList.Add("Null",new NullState());
    MenuStateList.Add("Main",new MainState());
    MenuStateList["Main"].SetUp();
    MenuStateList.Add("Status",new StatusState());
    MenuStateList["Status"].SetUp();
    MenuStateList.Add("InventorySelect",new InventorySelectState());
    MenuStateList["InventorySelect"].SetUp();
    MenuStateList.Add("ItemUse",new ItemUseState());
    MenuStateList["ItemUse"].SetUp();


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
  public static void MenuOff(){
    MenuState = MenuStateList["Null"];

  }
}
