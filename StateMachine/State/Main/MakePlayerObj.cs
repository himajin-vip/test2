﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class MakePlayerObj : IState
{
    private MoveManager MoveManager;
    PlayerObjectManager Player;
    public MakePlayerObj(MoveManager move,PlayerObjectManager player){
        MoveManager = move;
        Player = player;
    }
    
    public void Start(StateData stateData){
        GameObject obj = (GameObject)Resources.Load("prefab/Player/Player");
        GameObject Object = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
        Move move = new ContorolerMove(Object.transform,Object.GetComponent<Animator>(),new IntValue(3));
        MoveManager.Add(MoveState.Main,Object,move);
        Player.SetObject();
        Player.GetPlayer().LoadStatus(Statuss.Name,new StringValue("FirstPlayer"));
        new CSVLoader().StatusLoad(Player.GetPlayer());
        

    }
    public void Update(){
        GameManager.SetState(States.CameraSetUp,new StateData());

    }
    public void End(){

    }
}
