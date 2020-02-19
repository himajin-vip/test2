using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomMoveValue:IntClass
{
    bool on = false;
    CountChecker CountChecker = new CountChecker(32);
    public void Set(){
        Value = Random.Range(-2,3);
        if(Value != 0){
            on = true;
        }
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
