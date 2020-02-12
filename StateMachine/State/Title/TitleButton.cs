using UnityEngine;

public class TitleButton : MonoBehaviour
{
    public bool newGameOn{get; private set;} = false;
    public bool loadGameOn{get; private set;} = false;
    public bool returnTitleOn{get; private set;} = false;

    public bool newGameStart{get; private set;} = false;

    public bool loadGameStart{get; private set;} = false;

    public void NewGameOn(){
      newGameOn = true;
    }

    public void NewGameOff(){
      newGameOn =false;
    }
    public void LoadGameOn(){
      loadGameOn = true;
    }
    public void LoadGameOff(){
      loadGameOn = false;
    }

    public void NewGameStartOn(){
      newGameStart = true;
    }
    public void NewGameStartOff(){
      newGameStart = false;
    }

    public void LoadGameStartOn(){
      loadGameStart = true;
    }
    public void LoadGameStartOff(){
      loadGameStart = false;
    }

    public void ReturnTitleOn(){
      returnTitleOn = true;
    }
    public void ReturnTitleOff(){
      returnTitleOn = false;
    }
}
