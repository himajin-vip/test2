using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Timer
{
    int SetCount;
    float count ;
    public Timer(int setCount){
        SetCount = setCount;
    }
    public bool CountUp(){
        if(SetCount>count){
            count += 1 * Time.deltaTime;
            return true;
        }
        count = 0;
        return false;
    }
}