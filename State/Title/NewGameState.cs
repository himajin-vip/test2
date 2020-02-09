using UnityEngine;
using UnityEngine.UI;

public class NewGameState : IState
{
    private GameObject NewGameCanvas;
    private Text NewNameText;
    private Text NewPassWordText;
    private GameObject NewGameError;
    private TitleButton TitleButton;
    public void Start()
    {
        NewGameCanvas = GameObject.Find("NewGameCanvas").transform.Find("Panel").gameObject;
        NewGameCanvas.SetActive(true);
        NewNameText = NewGameCanvas.transform.Find("Name").transform.Find("Text").GetComponent<Text>();
        NewPassWordText = NewGameCanvas.transform.Find("PassWord").transform.Find("Text").GetComponent<Text>();
        NewGameError = NewGameCanvas.transform.Find("Error").gameObject;
        TitleButton = GameObject.Find("TitleButton").GetComponent<TitleButton>();
    }
    public void Update()
    {
        if(TitleButton.newGameStart){
            MakeNewAccount makeNewAccount = new MakeNewAccount();
            if(makeNewAccount.Make(NewNameText.text,NewPassWordText.text)){
                TitleButton.NewGameStartOff();
                GameManager.SetState("MakeNewCharactor");
            }else{
                TitleButton.NewGameStartOff();
                NewGameError.SetActive(true);
            }
        }
        if(TitleButton.returnTitleOn){
            TitleButton.ReturnTitleOff();
            GameManager.SetState("Title");
        }
        
    }
    public void End()
    {
        NewGameCanvas.SetActive(false);
        NewGameError.SetActive(false);
    }
}
