using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomMoveValue:IntClass
{
    bool on = false;
    CountChecker CountChecker = new CountChecker(32);
    public void Set(){
        Value = Random.Range(-2,10);
        on = true;
    }
    public bool On(){
        return on;
    }
    public void Count(){
        if(!CountChecker.CountUp()){
            on = false;
        }
    }
}
