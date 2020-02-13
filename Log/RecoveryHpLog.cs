using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryHpLog:LogMaker
{
    public RecoveryHpLog(string Name,int recovery){
        string newlog = (Name+"はHPを"+recovery+"回復した");
        logCanvas.MakeLog(newlog);
    }
}
