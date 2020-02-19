using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove:Move
{
    RandomMoveValue randx ;
    RandomMoveValue randy ;
    public RandomMove(Transform t){
        transform = t;
    }
    public override void Check(){
        if(!randx.On()==!randx.On()){
            RandomSet();
        }
        if(randx.On()){
            Xmove();
        }
        if(randy.On()){
            Ymove();
        }
    }
    public void RandomSet(){
        randx.Set();
        if(randx.GetIntValue() == 0){
            randy.Set();
        }
    }
    private void Xmove(){
        randx.Count();
        switch(randx.GetIntValue()){
            case 1:
                Right();
            break;
            case -1:
                Left();
            break;
        }
    }
    private void Ymove(){
        randx.Count();
        switch(randx.GetIntValue()){
            case 1:
                Up();
            break;
            case -1:
                Down();
            break;
        }
    }

}