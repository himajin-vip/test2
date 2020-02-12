using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameState : IState
{
    private GameObject LoadGameCanvas;
    private Text LoadNameText;
    private Text LoadPassWordText;
    private GameObject LoadGameError;
    private TitleButton TitleButton;
    public void Start()
    {
        LoadGameCanvas = GameObject.Find("LoadCanvas").transform.Find("Panel").gameObject;
        LoadGameCanvas.SetActive(true);
        LoadNameText = LoadGameCanvas.transform.Find("Name").transform.Find("Text").GetComponent<Text>();
        LoadPassWordText = LoadGameCanvas.transform.Find("PassWord").transform.Find("Text").GetComponent<Text>();
        LoadGameError = LoadGameCanvas.transform.Find("Error").gameObject;
        TitleButton = GameObject.Find("TitleButton").GetComponent<TitleButton>();      
    }
    public void Update()
    {
        if(TitleButton.loadGameStart){
            LoadAccount loadAccount = new LoadAccount();
            if(loadAccount.LoadGame(LoadNameText.text, LoadPassWordText.text)){
                TitleButton.LoadGameStartOff();
                GameManager.SetState("MakeLoadCharactor");
            }else{
                TitleButton.LoadGameStartOff();
                LoadGameError.SetActive(true);
            }
        }
        if(TitleButton.returnTitleOn){
            TitleButton.ReturnTitleOff();
            GameManager.SetState("Title");
        }

    }
    public void End()
    {
        LoadGameCanvas.SetActive(false);
        LoadGameError.SetActive(false);
    }
}
