using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraMoveValue:IntClass
{
    bool on = false;
    CountChecker CountChecker;
    public CameraMoveValue(){
    }
    public void Set(int Direction,int MapSizeXY){
        Value = Direction;
        CountChecker = new CountChecker(MapSizeXY);
        on = true;
    }
    public bool On(){
        return on;
    }
    public void Count(){
        if(!CountChecker.CountUp()){
            GameManager.SetState("Main");
            on = false;
        }
    }
}