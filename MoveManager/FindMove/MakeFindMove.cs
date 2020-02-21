using UnityEngine;
using System.Collections.Generic;
public class MakeFindMove
{
    public Move Make(GameObject enemy, GameObject player){
        return new FindMove(enemy.transform,enemy.GetComponent<Animator>(),new IntValue(1),player.transform);
    }

}