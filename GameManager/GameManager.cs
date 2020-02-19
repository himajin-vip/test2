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

      MoveManager move = new MoveManager();

      SpaceContoroler space = new SpaceContoroler();

      List<Enemy> HitList = new List<Enemy>();
      SkillControler skill = new SkillControler(HitList);
      
      PlayerObjectManager player = new PlayerObjectManager();

      SeanState.Add(States.MakePlayerObj,new MakePlayerObj(move,player));
      SeanState.Add(States.CameraSetUp, new CameraMoveSetState(move));
      SeanState.Add(States.Main,new MainState(move,space));
      SeanState.Add(States.MapMove,new MapMoveState(move));
      SeanState.Add(States.AtackState,new AtackState(skill,player,move));
      SeanState.Add(States.EnemyDamage,new EnemyDamageState(skill,player));
      
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
