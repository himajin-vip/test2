using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoveState : IState
{
    Controler controler;
    CameraManager cameraManager;
    public void Start()
    {
        controler = new MapMoveControler();
        cameraManager = new CameraManager();
    }
    public void Update()
    {
        cameraManager.PlayerPosCheck();
        controler.Check();
        UI_Manager.StatusUpdate();
        ShortcutManager.AllPiecesReset();
    }
    public void End()
    {

    }
}
