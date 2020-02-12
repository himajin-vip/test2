using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainState : IState
{
    Controler controler = new MainControler();
    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        controler.Check();
        CameraManager.PlayerPosCheck();
        UI_Manager.StatusUpdate();
        ShortcutManager.AllPiecesReset();

        GameManager.PlayerDeathCheck();

        EnemyManager.EnemyUpdate();
        EnemyManager.MakeEnemy();
    }

    public void End()
    {

    }
}
