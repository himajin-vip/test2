using UnityEngine;

public class TitleState:IState
{   
    private GameObject TitleCanvas;
    private TitleButton TitleButton;

    public void Start()
    {
        TitleCanvas = GameObject.Find("TitleCanvas").transform.Find("Panel").gameObject;
        TitleCanvas.SetActive(true);
        TitleButton = GameObject.Find("TitleButton").GetComponent<TitleButton>();
    }

    public void Update()
    {
        if(TitleButton.newGameOn){
            TitleButton.NewGameOff();
            GameManager.SetState("NewGame");
        }
        if(TitleButton.loadGameOn){
            TitleButton.LoadGameOff();
            GameManager.SetState("Load");
        }
    }

    public void End()
    {
        TitleCanvas.SetActive(false);
    }
}
