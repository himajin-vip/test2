using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownState : IState
{
    Controler Controler;
    public void Start()
    {
        Controler = new TownControler();
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
