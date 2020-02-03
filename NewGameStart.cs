using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewGameStart : MonoBehaviour
{
    public GameObject TitelCanvas;
    public GameObject NewGameCanvas;
    public GameObject LoadGameCanvas;
    public Text NewNameText;
    public Text NewPassWordText;
    public Text LoadNameText;
    public Text LoadPassWordText;
    public GameObject NewGameError;
    public GameObject LoadGameError;

    public void NewGameCanvasOn(){
      TitelCanvas.SetActive(false);
      NewGameCanvas.SetActive(true);
    }
    public void LoadGameCanvasOn(){
      TitelCanvas.SetActive(false);
      LoadGameCanvas.SetActive(true);
    }

    public void NewGameStartButton(){
      if(DataManager.NewCharacter(NewNameText.text,NewPassWordText.text)){
        SceneManager.LoadScene("Main");
      }else{
        NewGameError.SetActive(true);
      }
    }

    public void LoadGameStartButton(){
      if(DataManager.LoadGame(LoadNameText.text, LoadPassWordText.text)){
        SceneManager.LoadScene("Main");
      }else{
        LoadGameError.SetActive(true);
      }
    }

    public void ReturnTitle(){
      TitelCanvas.SetActive(true);;
      NewGameCanvas.SetActive(false);
      LoadGameCanvas.SetActive(false);
      NewGameError.SetActive(false);
      LoadGameError.SetActive(false);
    }
}
