using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageLog:LogMaker
{    
    public DamageLog(string Name,int damage){
        string newlog = (Name+"は"+damage+"のダメージを受けた");
        logCanvas.MakeLog(newlog);
    }
}
