using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : IState
{
    public void Start()
    {
        SceneManager.LoadScene("Main");
        
    }

    public void Update()
    {
        
    }

    public void End()
    {

    }
}
