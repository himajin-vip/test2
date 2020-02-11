using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainState : IState
{
    // Start is called before the first frame update
    public void Start()
    {
        ControlManager.KeyChenge("Main");
    }

    // Update is called once per frame
    public void Update()
    {
        ControlManager.Check();
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
