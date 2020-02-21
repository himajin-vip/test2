﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoveState : IState
{
    MoveManager MoveManager;
    EnemyManager enemyManager;
    MapManager mapManager;
    public MapMoveState(MoveManager moveManager,EnemyManager enemy,MapManager map){
        MoveManager = moveManager;
        enemyManager = enemy;
        mapManager = map;
    }
    public void Start(StateData stateData)
    {
        MoveManager.SetState(MoveState.MapMove);
        enemyManager.MapMove(MoveManager);
        mapManager.MapMove(stateData);
    }
    public void Update()
    {
        MoveManager.Check();
    }
    public void End(){
        enemyManager.MakeEnemy(mapManager.GetEnemys(),MoveManager);

    }
}
