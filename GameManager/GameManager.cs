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

      MoveManager move = new MoveManager();

      SpaceContoroler space = new SpaceContoroler();

      SkillControler skill = new SkillControler();
      
      PlayerObjectManager player = new PlayerObjectManager();

      EnemyManager enemy = new EnemyManager();
      MapManager map = new MapManager();
      ///////セットアップ
      SeanState.Add(States.MakePlayerObj,new MakePlayerObj(move,player));
      SeanState.Add(States.CameraSetUp, new CameraMoveSetState(move));
      SeanState.Add(States.SetEnemyLibrary ,new SetEnemyLibrary(enemy));




      ////////メインシーン
      SeanState.Add(States.Main,new MainState(move,space));
      SeanState.Add(States.MapMove,new MapMoveState(move,enemy,map));
      SeanState.Add(States.AtackState,new AtackState(skill,player,move));
      SeanState.Add(States.EnemyDamage,new EnemyDamageState(skill,player));
      SeanState.Add(States.ChargeSet,new ChargeSetState(skill,player));
      SeanState.Add(States.PlayerFind,new PlayerFindState(move));
      
    }

    void Start(){
      SeanState.Start(States.MakePlayerObj);
    }

    void Update()
    {
      SeanState.Update();
    }


    public static void SetState(States NextState,StateData stateData){
      LastState = NowState;
      NowState = NextState;
      SeanState.Set(NextState,stateData);
    }
    public static void ReturnState(StateData stateData){
      States NextState = LastState;
      LastState = NowState;
      NowState = NextState;
      SeanState.Set(NextState,stateData);
    }

}
