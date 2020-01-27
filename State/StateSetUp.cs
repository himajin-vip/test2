using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateSetUp : UpdateState
{
    public void Start()
    {
      PlayerManager.SetUp("Fighter");
      LogManager.SetUp();
      CameraManager.SetUp();
      EnemyManager.SetUp();
      InventoryManager.SetUp();
      ItemManager.SetUp();
      ShortcutManager.SetUp();
      UI_Manager.SetUp();
      MenuManager.SetUp();
    }

    public void Update()
    {
      GameManager.StateSet("Main");
    }

    public void End(){

    }
}
