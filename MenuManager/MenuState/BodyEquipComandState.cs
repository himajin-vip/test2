using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyEquipComandState : MenuState
{
  public GameObject EquipComandWindow;
  public GameObject Curesol;
  public RectTransform CursolTransform;
  public float CursolPosition = -10;
  public float newPosy;
  public int CursolPos;

  public void SetUp(){
    EquipComandWindow = GameObject.Find("MenuCanvas").transform.Find("InventoryPanel").transform.Find("EquipComandWindow").gameObject;
    Curesol = EquipComandWindow.transform.Find("SelectCursol").gameObject;
    CursolTransform = Curesol.GetComponent<RectTransform>();
  }
  public void Start(){
    EquipComandWindow.SetActive(true);
    Curesol.SetActive(true);
    CursolPos = 0;
    CursolPosition = -10;
    CursolTransform.anchoredPosition = new Vector2(10,-10);
  }
  public void CursolMove(int direction){
    switch(direction){
      case 0:
        if(CursolPosition > -70){
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
        PlayerManager.BodyEquip(InventoryManager.ReturnSelectItem());
        MenuManager.SetMenuState("BodyEquip");
      break;
      case 1:
        InventoryManager.ItemReduce(InventoryManager.ReturnSelectItem());
        MenuManager.SetMenuState("BodyEquip");
      break;
      case 2:
        MenuManager.SetMenuState("BodyEquip");
      break;
    }
  }
  public void End(){
    EquipComandWindow.SetActive(false);
    Curesol.SetActive(false);
  }
}
