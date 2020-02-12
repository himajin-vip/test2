using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainState : IState
{
    Controler controler ;
    CameraManager cameraManager;
    public void Start()
    {
        controler= new MainControler();
        cameraManager = new CameraManager();
    }

    // Update is called once per frame
    public void Update()
    {
        controler.Check();
        cameraManager.PlayerPosCheck();
        UI_Manager.StatusUpdate();
        ShortcutManager.AllPiecesReset();
        EnemyManager.EnemyUpdate();
        EnemyManager.MakeEnemy();
    }

    public void End()
    {

    }
}
