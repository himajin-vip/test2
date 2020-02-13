using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectShortCutState : IMenuState
{
  public GameObject SelectShortCutWindow;
  public GameObject Curesol;
  public RectTransform CursolTransform;
  public float CursolPosition = -10;
  public float newPosy;
  public int CursolPos;

  public void SetUp(){
    SelectShortCutWindow = GameObject.Find("MenuCanvas").transform.Find("InventoryPanel").transform.Find("SelectShortCutWindow").gameObject;
    Curesol = SelectShortCutWindow.transform.Find("SelectCursol").gameObject;
    CursolTransform = Curesol.GetComponent<RectTransform>();
  }
  public void Start(){
    SelectShortCutWindow.SetActive(true);
    Curesol.SetActive(true);
    CursolPos = 0;
    CursolPosition = -10;
    CursolTransform.anchoredPosition = new Vector2(10,-10);
  }
  public void CursolMove(int direction){
    switch(direction){
      case 0:
        if(CursolPosition > -130){
          newPosy = CursolPosition -= 30;
          CursolTransform.anchoredPosition = new Vector2(10,newPosy);
          CursolPos++;
        }
      break;
      case 1:
        if(CursolPosition < -10){
          newPosy = CursolPosition += 30;
          CursolTransform.anchoredPosition =new Vector2(10,newPosy);
          CursolPos--;
        }
      break;
    }
  }
  public void CursolOn(){
    switch(CursolPos){
      case 0:
        ShortcutManager.SetShortcut(1,MenuManager.SelectItemID);
        MenuManager.SetMenuState("UseItem");
      break;
      case 1:
        ShortcutManager.SetShortcut(2,MenuManager.SelectItemID);
        MenuManager.SetMenuState("UseItem");
      break;
      case 2:
        ShortcutManager.SetShortcut(3,MenuManager.SelectItemID);
        MenuManager.SetMenuState("UseItem");
      break;
      case 3:
        ShortcutManager.SetShortcut(4,MenuManager.SelectItemID);
        MenuManager.SetMenuState("UseItem");
      break;
      case 4:
        MenuManager.SetMenuState("UseComand");
      break;
    }
  }
  public void End(){
    SelectShortCutWindow.SetActive(false);
    Curesol.SetActive(false);
  }
}
