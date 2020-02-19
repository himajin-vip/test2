using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove:Move
{
    RandomMoveValue RandomMoveValue;
    Direction direction;
    public RandomMove(Transform t,Animator animator){
        transform = t;
        direction = new Direction(animator);
    }
    public override void Check(){
        if(!RandomMoveValue.On()){
            RandomMoveValue.Set();
        }
        if(RandomMoveValue.On()){
            move();
        }
    
    }
    private void move(){
        RandomMoveValue.Count();
        switch(RandomMoveValue.GetIntValue()){
            case 1:
                direction.Right();
                Right();
            break;
            case -1:
                direction.Left();
                Left();
            break;
            case 2:
                direction.Up();
                Up();
            break;
            case -2:
                direction.Down();
                Down();
            break;
        }
    }

}