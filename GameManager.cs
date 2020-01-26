using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      ItemManager.SetUp();
      InventoryManager.SetUp();
      CameraManager.SetUp();
      UI_Manager.SetUp();
      ShortcutManager.SetUp();
      PlayerManager.SetUp("Fighter");
    }

    // Update is called once per frame
    void Update()
    {
      CameraManager.PlayerCheck();
      ControlManager.KeyCheck();
      UI_Manager.UiStatusUpdate();
      ShortcutManager.update();
      EnemyManager.MakeEnemy("Slime");
    }

}
