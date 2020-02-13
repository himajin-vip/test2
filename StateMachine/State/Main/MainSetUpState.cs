using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSetUpState : IState
{
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {

        MapManager.SetUp();
        AccountData.PlayerSet();
        ItemDrop.SetUp();
        new LogMaker().SetUp();
        new CameraManager().SetUp();
        new UI_Manager().SetUp();
        new ShortcutManager().SetUp();
        AudioManager.SetUp();
        new EnemyManager().SetUp();
        new MenuManager().SetUp();
        new ItemManager().SetUp();
        
        GameManager.SetState("Town");
        MapManager.StartMap();
    }
    public void End()
    {

    }
}
