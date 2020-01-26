using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Menu : MonoBehaviour
{
  public GameObject MainMenuCanvas;

    public void MenuOn(){
      MainMenuCanvas.gameObject.SetActive(true);
    }
    public void MenuOff(){
      MainMenuCanvas.gameObject.SetActive(false);
    }
    public void OnClick(string button){
      switch(button){
        case "Close":
          MainMenuCanvas.gameObject.SetActive(false);
        break;
        case "End":
          SceneManager.LoadScene("title");
        break;
      }
    }
}
