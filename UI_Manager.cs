using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UI_Manager
{
  private static UI_Status UiStatus;
  private static UI_Menu UiMenu;
  private static bool MainMenuOn;

  public static void SetUp(){
    UiStatus = GameObject.Find("StatusCanvas").GetComponent<UI_Status>();
    UiMenu = GameObject.Find("MenuCanvas").GetComponent<UI_Menu>();
    MainMenuOn = false;
  }
  public static void UiStatusUpdate(){
    UiStatus.update();
  }
  public static void MenuOn(){
    if(!MainMenuOn){
      UiMenu.MenuOn();
      MainMenuOn = true;
    }else{
      UiMenu.MenuOff();
      MainMenuOn = false;
    }
  }


}
