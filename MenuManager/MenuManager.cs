using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class MenuManager
{
  private static Dictionary<string,MenuState> MenuStateList = new Dictionary<string,MenuState>();
  private static MenuState MenuState;
  private static bool InventoryEndfrag;

  public static void SetUp(){
    MenuStateList.Clear();
    InventoryEndfrag = true;




    MenuStateList.Add("Null",new NullState());

    MenuStateList.Add("Main",new MainState());
    MenuStateList["Main"].SetUp();

    MenuStateList.Add("Status",new StatusState());
    MenuStateList["Status"].SetUp();

    MenuStateList.Add("InventorySelect",new InventorySelectState());
    MenuStateList["InventorySelect"].SetUp();

    MenuStateList.Add("UseItem",new ItemUseState());
    MenuStateList["UseItem"].SetUp();

    MenuStateList.Add("UseComand",new UseComandState());
    MenuStateList["UseComand"].SetUp();

    MenuStateList.Add("SelectShortCut", new SelectShortCutState());
    MenuStateList["SelectShortCut"].SetUp();


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
    MenuStateList["Main"].End();
    MenuStateList["Status"].End();
    InventoryEndfrag = true;
    MenuStateList["InventorySelect"].End();
    MenuStateList["UseItem"].End();
    MenuStateList["UseComand"].End();
    MenuStateList["SelectShortCut"].End();

    GameManager.StateSet("Main");

  }

  public static void InventoryEndFragToggle(bool frag){
    if(frag){
      InventoryEndfrag = true;
    }else{
      InventoryEndfrag = false;
    }
  }
  public static bool ReturnInventoryEndfrag(){
    return InventoryEndfrag;
  }
}
