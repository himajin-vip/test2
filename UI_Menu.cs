using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Menu : MonoBehaviour
{
  public GameObject MainMenuCanvas;

    public void MenuOn(){
      MainMenuCanvas.gameObject.SetActive(true);
      UpdateManager.StateSet("Menu");
    }
    public void MenuOff(){
      MainMenuCanvas.gameObject.SetActive(false);
      UpdateManager.StateSet("Main");
    }
    public void OnClick(string button){
      switch(button){
        case "Close":
          MenuOff();
        break;
        case "End":
          SceneManager.LoadScene("title");
        break;
      }
    }
}
