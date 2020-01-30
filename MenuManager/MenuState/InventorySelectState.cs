using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySelectState: MenuState{
  public GameObject InventoryCanvas;
  public Text[] ItemText;
  public GameObject Curesol;
  public RectTransform CursolTransform;
  public float CursolPosition = -10;
  public float newPosy;
  public int CursolPos;

  public void SetUp(){
    InventoryCanvas = GameObject.Find("MenuCanvas").transform.Find("InventoryPanel").gameObject;
    Curesol = InventoryCanvas.transform.Find("SelectWindow").transform.Find("SelectCursol").gameObject;
    CursolTransform = Curesol.GetComponent<RectTransform>();

  }
  public void Start(){
    MenuManager.InventoryEndFragToggle(false);
    CursolPos = 0;
    CursolPosition = -10;
    CursolTransform.anchoredPosition = new Vector2(10,-10);
    InventoryCanvas.SetActive(true);
    Curesol.SetActive(true);
  }
  public void CursolMove(int direction){
    switch(direction){
      case 0:
        if(CursolPosition > -250){
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
        MenuManager.SetMenuState("UseItem");
      break;
      case 1:

      break;
      case 2:

      break;
      case 3:

      break;
      case 4:

      break;
      case 5:

      break;
      case 6:

      break;
      case 7:

      break;
      case 8:
        MenuManager.InventoryEndFragToggle(true);
        MenuManager.SetMenuState("Main");
      break;
    }
  }
  public void End(){
    if(MenuManager.ReturnInventoryEndfrag()){
      InventoryCanvas.SetActive(false);
    }
    Curesol.SetActive(false);
  }
}
