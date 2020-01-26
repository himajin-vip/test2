using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UpdateManager
{
  private static Dictionary<string,UpdateState> StateList = new Dictionary<string,UpdateState>();
  private static UpdateState UpdateState;

  public static void SetUp(){
    UpdateState Mainstate = new MainState();
    StateList.Add("Main",Mainstate);
  }
  public static void StateSet(string state){
    UpdateState = StateList[state];
    UpdateState.Start();
  }
  public static void StateUpdate(){
    UpdateState.Update();
  }

}
