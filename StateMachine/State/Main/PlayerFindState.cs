using UnityEngine;
public class PlayerFindState : IState
{
    MoveManager moveManager;
   public PlayerFindState(MoveManager move){
        moveManager = move;
    }
    public void Start(StateData stateData){
        GameObject enemy = stateData.enemy.GetObj();
        GameObject player = stateData.player.GetObj();
        moveManager.Add(MoveState.Main,enemy,new MakeFindMove().Make(enemy,player));
        GameManager.SetState(States.Main,new StateData());
    }
    public void Update(){
    }
    public void End(){
    }
}