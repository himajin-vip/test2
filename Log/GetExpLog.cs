using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetExpLog:LogMaker
{    
    public GetExpLog(string Name ,int Exp){
        string newlog = (Name+"は"+Exp+"の経験値を手に入れた");
        logCanvas.MakeLog(newlog);
    }
}
