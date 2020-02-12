using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownState : IState
{
    Controler Controler = new TownControler();
    public void Start()
    {

    }
    public void Update()
    {
        Controler.Check();
        CameraManager.PlayerPosCheck();
        UI_Manager.StatusUpdate();
        ShortcutManager.AllPiecesReset();
    }
    public void End()
    {

    }
}
