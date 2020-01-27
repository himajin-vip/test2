using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StateFirst : UpdateState
{
    public void Start()
    {

    }

    public void Update()
    {
      GameManager.StateSet("SetUp");
    }
    public void End(){

    }
}
