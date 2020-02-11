using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownState : IState
{
    public void Start()
    {
        ControlManager.KeyChenge("Town");
    }
    public void Update()
    {
        ControlManager.Check();
        CameraManager.PlayerPosCheck();
        UI_Manager.StatusUpdate();
        ShortcutManager.AllPiecesReset();
    }
    public void End()
    {

    }
}
