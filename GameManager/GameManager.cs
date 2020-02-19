using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  private static StateMachine SeanState = new StateMachine();
  public static string NowState{get; private set;}
  public static string LastState{get; private set;}

    static GameManager()
    {
      ItemLibrary itemLibrary = new ItemLibrary();
      new ItemDataSetUper(itemLibrary);

      MoveManager moveManager = new MoveManager();

      SeanState.Add("MakePlayerObject",new MakePlayerObj(moveManager));
      SeanState.Add("Main",new MainState(moveManager));
      SeanState.Add("MapMove",new MapMoveState(moveManager));
      
    }

    void Start(){
      SeanState.Start("MakePlayerObject");
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

}
