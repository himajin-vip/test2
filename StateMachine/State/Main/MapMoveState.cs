using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoveState : IState
{
    MoveManager MoveManager;
    public MapMoveState(MoveManager moveManager){
        MoveManager = moveManager;
    }
    public void Start()
    {
        MoveManager.SetState(MoveState.MapMove);
    }
    public void Update()
    {
        MoveManager.Check();
    }
    public void End()
    {

    }
}
