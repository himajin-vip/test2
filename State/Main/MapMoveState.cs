using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoveState : IState
{
    Controler controler = new MapMoveControler();
    public void Start()
    {

    }
    public void Update()
    {
        CameraManager.PlayerPosCheck();
        controler.Check();
        UI_Manager.StatusUpdate();
        ShortcutManager.AllPiecesReset();
    }
    public void End()
    {

    }
}
