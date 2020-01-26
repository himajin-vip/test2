using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSetUp : UpdateState
{
    // Start is called before the first frame update
    public void Start()
    {
      ItemManager.SetUp();
      InventoryManager.SetUp();
      CameraManager.SetUp();
      UI_Manager.SetUp();
      ShortcutManager.SetUp();
      PlayerManager.SetUp("Fighter");
      LogManager.SetUp();
    }

    // Update is called once per frame
    public void Update()
    {
      Debug.Log("MoveMain");
      UpdateManager.StateSet("Main");
    }

    public void End(){

    }
}
