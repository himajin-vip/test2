using UnityEngine;
using System.Collections.Generic;
public class MakeFindMove
{
    public void Check(Dictionary<Enemy,Player> enemylist,MoveManager move){
        if(enemylist.Count != 0){
            foreach(KeyValuePair<Enemy,Player> pair in enemylist){
            move.Add(MoveState.Main,pair.Key.GetObj(),Make(pair.Key.GetObj(),pair.Value.GetObj()));
            move.Add(MoveState.Atack,pair.Key.GetObj(),Make(pair.Key.GetObj(),pair.Value.GetObj()));
            }
        }
    }
    public Move Make(GameObject enemy, GameObject player){
        return new FindMove(enemy.transform,enemy.GetComponent<Animator>(),new IntValue(1),player.transform);
    }

}