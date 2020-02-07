using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMain : UpdateState
{

    public void Start()
    {
      ControlManager.KeyChenge("Main");
    }

    public void Update()
    {
      PlayerManager.PlayerDeathCheck();
      EnemyManager.EnemyUpdate();
      CameraManager.PlayerPosCheck();
      ControlManager.Check();
      UI_Manager.UiStatusUpdate();
      ShortcutManager.AllPiecesReset();
      EnemyManager.MakeEnemy();
    }
    public void End(){
    }
}
