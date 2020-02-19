using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainState : IState
{
    MoveManager MoveManager;
    SpaceContoroler Space;
    Player player;
    public MainState(MoveManager moveManager,SpaceContoroler space){
        MoveManager = moveManager;
        Space = space;
    }
    public void Start()
    {
        MoveManager.SetState(MoveState.Main);
        Space.SetState(SpaceStates.Atack);
        player = new GetPlayerComponent().Get();
    }

    // Update is called once per frame
    public void Update()
    {
        MoveManager.Check();
        Space.Check();
    }

    public void End()
    {

    }
}
