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
        ControlManager.KeyChenge("Town");

        new MapManager();
        new CameraManager();
        new UI_Manager();
        new LogManager();
        new ShortcutManager();
        new AudioManager();
        new EnemyManager();
        new MenuManager();
        
        GameManager.SetState("Town");
    }
    public void End()
    {

    }
}
