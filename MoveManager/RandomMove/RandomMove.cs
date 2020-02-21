using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove:Move
{
    RandomMoveValue RandomMoveValue = new RandomMoveValue();
    Direction direction;
    public RandomMove(Transform t,Animator animator,Value moveSpeed){
        transform = t;
        direction = new Direction(animator);
        movespeed = moveSpeed;
    }
    public override void Check(){
        RandomMoveValue.Count();
        if(!RandomMoveValue.On()){
            RandomMoveValue.Set();
        }
        if(RandomMoveValue.On()){
            move();
        }
    
    }
    private void move(){
        float myx = transform.position.x;
        float myy = transform.position.y;
        switch(RandomMoveValue.GetIntValue()){
            case 1:
                if(new MapPosition().MaxX>myx+32){
                    direction.Right();
                    Right();
                }
            break;
            case -1:
                if(new MapPosition().MinX<myx-32){
                    direction.Left();
                    Left();
                }
            break;
            case 2:
                if(new MapPosition().MaxY>myy+32){
                    direction.Up();
                    Up();
                }
            break;
            case -2:
                if(new MapPosition().MinY<myy-32){
                    direction.Down();
                    Down();
                }
            break;
        }
    }

}