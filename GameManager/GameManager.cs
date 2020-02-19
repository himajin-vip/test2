using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  private static StateMachine SeanState = new StateMachine();
  public static string NowState{get; private set;}
  public static string LastState{get; private set;}

    public GameManager()
    {
      ItemLibrary itemLibrary = new ItemLibrary();
      new ItemDataSetUper(itemLibrary);
      LogMaker log = new LogMaker();
      //////タイトルシーン
      SeanState.Add("ToTitle",new ToTitleState());
      SeanState.Add("Title",new TitleState());
      SeanState.Add("NewGame", new NewGameState());
      SeanState.Add("Load", new LoadGameState());

      //////メインシーン
      SeanState.Add("MakeNewCharactor", new MakeNewCharactorState());
      SeanState.Add("MakeLoadCharactor",new MakeLoadCharactorState());
      SeanState.Add("Main",new MainState());
      SeanState.Add("MainSetUp",new MainSetUpState());
      SeanState.Add("MapMove",new MapMoveState());
      SeanState.Add("Town",new TownState());
      SeanState.Add("Menu", new MenuState());
      SeanState.Add("Shop", new ShopState());

      ///////エンドシーン
      SeanState.Add("ToEnd", new ToEndState());
      SeanState.Add("End", new EndState());
      
    }

    void Start(){
      DontDestroyOnLoad(gameObject);
      AccountData.SetUp();
      NowState = "Title";
      SeanState.Set("Title");
    }

    void Update()
    {
      SeanState.Update();
    }


    public static void SetState(string NextState){
      LastState = NowState;
      NowState = NextState;
      SeanState.Set(NextState);
    }

    // public static void PlayerpDeathCheck(){
    //   if(Playerp.Hp.currentValue<=0){
    //     Playerp.Hp.Reset();
    //     AccountData.Save();
    //     SetState("ToEnd");
    //   }
    // }

}
