using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainState : IState
{
    MoveManager MoveManager;
    Player player;
    public MainState(MoveManager moveManager){
        MoveManager = moveManager;
    }
    public void Start()
    {
        player = new GetPlayerComponent().Get();
    }

    // Update is called once per frame
    public void Update()
    {
        MoveManager.Check();
    }

    public void End()
    {

    }
}
