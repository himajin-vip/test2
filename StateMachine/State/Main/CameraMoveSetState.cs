using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMoveSetState : IState
{
    private MoveManager MoveManager;
    public CameraMoveSetState(MoveManager move){
        MoveManager = move;
    }
    public void Start()
    {
        GameObject Object = GameObject.FindGameObjectWithTag("Player").gameObject;
        Move CameraMove = new CameraMove(Object.transform);
        MoveManager.Add(MoveState.MapMove,Camera.main.gameObject,CameraMove);
        MoveManager.Add(MoveState.Main,Camera.main.gameObject,CameraMove);
        GameManager.SetState(States.Main);
    }

    public void Update()
    {
        
    }

    public void End()
    {

    }
}