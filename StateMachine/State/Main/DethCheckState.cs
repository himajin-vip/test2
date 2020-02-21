using UnityEngine;
public class DethCheckState : IState
{
    MoveManager moveManager;
    EnemyManager enemyManager;
   public DethCheckState(MoveManager move,EnemyManager enemy){
        moveManager = move;
        enemyManager = enemy;
    }
    public void Start(StateData stateData){
        if(typeof(Player) == stateData.Charactor.GetObj().GetComponent<Charactor>().GetType()){
            Debug.Log("プレイヤーだよ");
            return;
        }
        moveManager.Remove(stateData.Charactor.GetObj());
        moveManager.RemoveCheck();
        enemyManager.Remove(stateData.Charactor);
    }
    public void Update(){
    }
    public void End(){
    }
}