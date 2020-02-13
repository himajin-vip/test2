using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMaker
{
    protected static LogCanvas logCanvas;
    public void SetUp(){
        logCanvas = GameObject.Find("LogCanvas").GetComponent<LogCanvas>();
        logCanvas.SetUp();
    }
}
