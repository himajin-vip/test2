using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CountChecker
{
    int SetCount;
    int count;
    public CountChecker(int setCount){
        SetCount = setCount;
    }
    public bool CountUp(){
        if(SetCount>count){
            count++;
            return true;
        }
        count = 0;
        return false;
    }
}