using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseComandState : IMenuState
{
  public GameObject UseComandWindow;
  public GameObject Curesol;
  public RectTransform CursolTransform;
  public float CursolPosition = -10;
  public float newPosy;
  public int CursolPos;
  Playerp Playerp;

  public void SetUp(){
    UseComandWindow = GameObject.Find("MenuCanvas").transform.Find("InventoryPanel").transform.Find("UseComandWindow").gameObject;
    Curesol = UseComandWindow.transform.Find("SelectCursol").gameObject;
    CursolTransform = Curesol.GetComponent<RectTransform>();
    Playerp = GameObject.FindGameObjectWithTag("Playerp").GetComponent<Playerp>();
  }
  public void Start(){
    UseComandWindow.SetActive(true);
    Curesol.SetActive(true);
    CursolPos = 0;
    CursolPosition = -10;
    CursolTransform.anchoredPosition = new Vector2(10,-10);
  }
  public void CursolMove(int direction){
    switch(direction){
      case 0:
        if(CursolPosition > -100){
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
        // Playerp.ItemUse(new ItemID(MenuManager.SelectItemID));
        MenuManager.SetMenuState("UseItem");
      break;
      case 1:
        MenuManager.SetMenuState("SelectShortCut");
      break;
      case 2:
        // new InventoryReduce().Reduce(new ItemID(MenuManager.SelectItemID),new ItemPeace(1));
        MenuManager.SetMenuState("UseItem");
      break;
      case 3:
        MenuManager.SetMenuState("UseItem");
      break;
    }
  }
  public void End(){
    UseComandWindow.SetActive(false);
    Curesol.SetActive(false);
  }
}
