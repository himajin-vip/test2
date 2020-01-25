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

    public void CloseMenu(){
      MainMenuCanvas.gameObject.SetActive(false);
    }
    public void EndGame(){
      SceneManager.LoadScene("title");
    }
}
