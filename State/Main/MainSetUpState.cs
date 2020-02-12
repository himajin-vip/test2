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

        new MapManager().SetUp();
        new CameraManager().SetUp();
        new UI_Manager().SetUp();
        new LogManager().SetUp();
        new ShortcutManager().SetUp();
        new AudioManager().SetUp();
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
