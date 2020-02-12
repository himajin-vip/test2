using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : IMenuState
{
    public GameObject MainMenuCanvas;
    public GameObject MainMenuCursol;
    public RectTransform MainMenuCursolTransform;
    public float MainMenuCursolPosition = -10;
    public float newPosy;
    public int CursolPos;

    public void SetUp(){
      MainMenuCanvas = GameObject.Find("MenuCanvas").transform.Find("MainMenuPanel").gameObject;
      MainMenuCursol = MainMenuCanvas.transform.Find("MainMenuCursol").gameObject;
      MainMenuCursolTransform = MainMenuCursol.GetComponent<RectTransform>();
    }
    public void Start(){
      CursolPos = 0;
      MainMenuCursolPosition = -10;
      MainMenuCursolTransform.anchoredPosition = new Vector2(10,-10);
      MainMenuCanvas.gameObject.SetActive(true);
    }

    public void CursolMove(int direction){
      switch(direction){
        case 0:
          if(MainMenuCursolPosition > -190){
            newPosy = MainMenuCursolPosition -= 30;
            MainMenuCursolTransform.anchoredPosition = new Vector2(10,newPosy);
            CursolPos++;
          }
        break;
        case 1:
          if(MainMenuCursolPosition < -10){
            newPosy = MainMenuCursolPosition += 30;
            MainMenuCursolTransform.anchoredPosition =new Vector2(10,newPosy);
            CursolPos--;
          }
        break;
      }
    }
    public void CursolOn(){
      switch(CursolPos){
        case 0:
          MenuManager.SetMenuState("Status");
        break;
        case 1:
          MenuManager.SetMenuState("InventorySelect");
        break;
        case 2:
        break;
        case 3:
        break;
        case 4:
        break;
        case 5:
          MenuManager.SetMenuState("Null");
        break;
        case 6:
          GameManager.SetState("ToEnd");
        break;
      }
    }
    public void End(){
      MainMenuCanvas.gameObject.SetActive(false);
    }
}
