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

        
        
        // GameManager.SetState("Town");
        MapManager.StartMap();
    }
    public void End()
    {

    }
}
