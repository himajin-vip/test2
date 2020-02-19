using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  private static StateMachine SeanState = new StateMachine();
  private static States NowState;
  private static States LastState;

    static GameManager()
    {
      ItemLibrary itemLibrary = new ItemLibrary();
      new ItemDataSetUper(itemLibrary);

      MoveManager moveManager = new MoveManager();

      SpaceContoroler space = new SpaceContoroler();
      SkillControler skill = new SkillControler();
      PlayerObjectManager player = new PlayerObjectManager();

      SeanState.Add(States.MakePlayerObj,new MakePlayerObj(moveManager,player));
      SeanState.Add(States.CameraSetUp, new CameraMoveSetState(moveManager));
      SeanState.Add(States.Main,new MainState(moveManager,space));
      SeanState.Add(States.MapMove,new MapMoveState(moveManager));
      SeanState.Add(States.AtackState,new AtackState(skill,player));
      
    }

    void Start(){
      SeanState.Start(States.MakePlayerObj);
    }

    void Update()
    {
      SeanState.Update();
    }


    public static void SetState(States NextState){
      LastState = NowState;
      NowState = NextState;
      SeanState.Set(NextState);
    }

}
