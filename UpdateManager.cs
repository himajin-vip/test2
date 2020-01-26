using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UpdateManager
{
  private static Dictionary<string,UpdateState> StateList = new Dictionary<string,UpdateState>();
  private static UpdateState UpdateState;

  public static void SetUp(){
    UpdateState Mainstate = new StateMain();
    StateList.Add("Main",Mainstate);
    UpdateState Firststate = new StateFirst();
    StateList.Add("First",Firststate);
    UpdateState Menustate = new StateMenu();
    StateList.Add("Menu",Menustate);
    UpdateState MapMoveState = new StateMapMove();
    StateList.Add("MapMove",MapMoveState);

    UpdateState = StateList["First"];
    UpdateState.Start();
  }
  public static void StateSet(string state){
    UpdateState.End();
    UpdateState = StateList[state];
    Debug.Log("NextState:"+UpdateState);
    UpdateState.Start();
  }
  public static void StateUpdate(){
    UpdateState.Update();
  }

}
