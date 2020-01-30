using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateSetUp : UpdateState
{
    public void Start()
    {
      LogManager.SetUp();
      AudioManager.SetUp();
      CameraManager.SetUp();
      EnemyManager.SetUp();
      InventoryManager.SetUp();
      ItemManager.SetUp();
      ShortcutManager.SetUp();
      UI_Manager.SetUp();
      MenuManager.SetUp();
      PlayerManager.SetUp("Fighter");
    }

    public void Update()
    {
      GameManager.StateSet("Main");
    }

    public void End(){

    }
}
