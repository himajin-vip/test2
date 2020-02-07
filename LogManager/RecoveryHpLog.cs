using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoveryHpLog
{
    public RecoveryHpLog(string Name,int recovery){
        string newlog = (Name+"はHPを"+recovery+"回復した");
        LogManager.MakeLog(newlog);
    }
}
