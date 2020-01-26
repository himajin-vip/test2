using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMain : UpdateState
{

    public void Start()
    {

    }

    public void Update()
    {
      PlayerManager.PlayerDeathCheck();
      EnemyManager.EnemyUpdate();
      CameraManager.PlayerPosCheck();
      ControlManager.KeyCheck();
      UI_Manager.UiStatusUpdate();
      ShortcutManager.update();
      EnemyManager.MakeEnemy("Slime");
    }
    public void End(){

    }
}
