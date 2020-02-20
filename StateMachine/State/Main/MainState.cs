using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainState : IState
{
    MoveManager MoveManager;
    SpaceContoroler Space;
    SkillControler SkillControler;
    EnemyManager EnemyManager;
    Player player;
    public MainState(MoveManager moveManager,SpaceContoroler space,EnemyManager enemy){
        MoveManager = moveManager;
        Space = space;
        EnemyManager = enemy;
    }
    public void Start(StateData stateData)
    {
        MoveManager.SetState(MoveState.Main);
        Space.SetState(SpaceStates.Atack);
        player = new GetPlayerComponent().Get();

    }

    // Update is called once per frame
    public void Update()
    {
        new MakeFindMove().Check(EnemyManager.FindCheck(),MoveManager);
        MoveManager.Check();
        Space.Check();
        player.EfectCount();
    }

    public void End(){

    }
}
