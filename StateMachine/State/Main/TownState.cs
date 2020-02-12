using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownState : IState
{
    Controler Controler;
    CameraManager cameraManager;
    public void Start()
    {

        Controler = new TownControler();
        cameraManager = new CameraManager();
    }
    public void Update()
    {
        Controler.Check();
        cameraManager.PlayerPosCheck();
        UI_Manager.StatusUpdate();
        ShortcutManager.AllPiecesReset();
    }
    public void End()
    {

    }
}
