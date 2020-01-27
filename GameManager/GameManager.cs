using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  private static Dictionary<string,UpdateState> StateList = new Dictionary<string,UpdateState>();
  private static UpdateState UpdateState;
  private static bool StartTrigger = true;
  private static bool UpdateTrigger = true;
  private static bool First = true;

    void Start()
    {
      Debug.Log("GameManagerStart");
      if(First){
      StateList.Add("Main",new StateMain());
      StateList.Add("First",new StateFirst());
      StateList.Add("Menu",new StateMenu());
      StateList.Add("MapMove",new StateMapMove());
      StateList.Add("End",new StateEnd());
      StateList.Add("Load",new StateLoad());
      StateList.Add("SetUp",new StateSetUp());
      StateList.Add("Title",new StateTitle());
        UpdateState = StateList["First"];
        First = false;
      }else{
        UpdateState = StateList["Main"];
      }
    }

    void Update()
    {
      if(UpdateTrigger){
        UpdateState.Update();
      }
    }

    public static void StateSet(string state){
      UpdateState.End();
      Debug.Log("NextState->"+state);
      UpdateState = StateList[state];
      UpdateState.Start();
    }
    public static void StartOn(){
      StartTrigger = true;
      UpdateState.Start();
      UpdateTrigger = true;
    }
    public static void StartOff(){
      StartTrigger = false;
    }
    public static void UpdateOn(){
      UpdateTrigger = true;
    }
    public static void UpdateOff(){
      UpdateTrigger = false;
    }

}
