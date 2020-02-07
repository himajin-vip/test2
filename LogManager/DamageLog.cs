using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageLog
{
    public DamageLog(string Name,int damage){
        string newlog = (Name+"は"+damage+"のダメージを受けた");
        LogManager.MakeLog(newlog);
    }
}
