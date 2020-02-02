using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  private static Dictionary<string,UpdateState> StateList = new Dictionary<string,UpdateState>();
  private static UpdateState UpdateState;
  private static string NowState;
  private static string LastState;

    void Start()
    {
      Debug.Log("GameManagerStart");
      StateList.Clear();
      StateList.Add("Main",new StateMain());
      StateList.Add("First",new StateFirst());
      StateList.Add("Menu",new StateMenu());
      StateList.Add("MapMove",new StateMapMove());
      StateList.Add("End",new StateEnd());
      StateList.Add("Load",new StateLoad());
      StateList.Add("SetUp",new StateSetUp());
      StateList.Add("Title",new StateTitle());
      StateList.Add("Town",new StateTown());
      UpdateState = StateList["First"];
      NowState = "First";
    }

    void Update()
    {
      UpdateState.Update();
    }

    public static void StateSet(string state){
      UpdateState.End();
      Debug.Log("NextState->"+state);
      UpdateState = StateList[state];
      UpdateState.Start();
      LastState = NowState;
      NowState = state;
    }

    public static string ReturnLastState(){
      return LastState;
    }

}
