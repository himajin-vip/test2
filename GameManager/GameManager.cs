using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  private static Dictionary<string,UpdateState> StateList = new Dictionary<string,UpdateState>();
  private static UpdateState UpdateState;

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
      UpdateState = StateList["First"];
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
    }

}
