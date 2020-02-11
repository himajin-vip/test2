using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoveState : IState
{
    public void Start()
    {
        ControlManager.KeyChenge("MapMove");
    }
    public void Update()
    {
        CameraManager.PlayerPosCheck();
        ControlManager.Check();
        UI_Manager.StatusUpdate();
        ShortcutManager.AllPiecesReset();
    }
    public void End()
    {

    }
}
