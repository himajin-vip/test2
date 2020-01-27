using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusState : MenuState
{
  GameObject StateMenu;

  public void SetUp(){
    StateMenu = GameObject.Find("MenuCanvas").transform.Find("StatusPanel").gameObject;
  }
  public void Start(){
    StateMenu.SetActive(true);
  }
  public void CursolMove(int direction){}
  public void CursolOn(){
    MenuManager.SetMenuState("Main");
  }
  public void End(){
    StateMenu.SetActive(false);
  }
}
