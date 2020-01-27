using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateSetUp : UpdateState
{
    public void Start()
    {
      Debug.Log("SetUpStateStart");
      PlayerManager.SetUp("Fighter");
      LogManager.SetUp();
      CameraManager.SetUp();
      InventoryManager.SetUp();
      ItemManager.SetUp();
      ShortcutManager.SetUp();
      UI_Manager.SetUp();
    }

    public void Update()
    {
      GameManager.StateSet("Main");
    }

    public void End(){

    }
}
