using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  private static StateMachine SeanState = new StateMachine();

  public static AccountData AccountData{get; private set;} = new AccountData();
  public static Player Player{get; private set;}
  private static string NowState;
  private static string LastState;

    void Start()
    {
      DontDestroyOnLoad(gameObject);
      AccountData.SetUp();
      SeanState.Add("Title",new TitleState());
      SeanState.Add("NewGame", new NewGameState());
      SeanState.Add("Load", new LoadGameState());
      SeanState.Add("MakeNewCharactor", new MakeNewCharactorState());
      SeanState.Add("MakeLoadCharactor",new MakeLoadCharactorState());
      SeanState.Add("Main",new MainState());

      
      
      SeanState.Set("Title");
    }

    void Update()
    {
      SeanState.Update();
    }

    public static string ReturnLastState(){
      return LastState;
    }

    public static void SetState(string NextState){
      SeanState.Set(NextState);
    }

    public static void MakeNewCharactor(){
      MakePlayerObject PlayerObject = new MakePlayerObject();
      Debug.Log(PlayerObject.Object);
      Player = new NewPlayer();
      Player.SetObjecct(PlayerObject.Object,PlayerObject.Object.GetComponent<Animator>());
    }
    public static void MakeLoadCharactor(){
      MakePlayerObject PlayerObject = new MakePlayerObject();
      Player = new LoadPlayer();
      Player.SetObjecct(PlayerObject.Object,PlayerObject.Object.GetComponent<Animator>());
    }

    public static void PlayerDeathCheck(){
      if(Player.Hp.currentValue<=0){
        Player.Hp.Reset();
        AccountData.Save();
        SetState("End");
      }
    }

}
