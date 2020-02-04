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
      PlayerManager.SetUp();
      DataManager.SetPlayerStatus();
      MapManager.SetUp();
      DataManager.Save();
    }

    public void Update()
    {
      GameManager.StateSet("Town");
    }

    public void End(){

    }
}
