using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold
{
    private int Value;

    public Gold(int value){
        Value = value;
    }
    public void Add(Gold gold){
        Value += gold.Value;
    }
    public bool Use(Gold gold){
        if(gold.Value > Value){
            return false;
        }
        Value -= gold.Value;
        return true;
    }
    public int GetValue(){
        return Value;
    }
}
