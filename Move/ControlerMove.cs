using UnityEngine;
public class ContorolerMove:Move
{
    Direction direction;
    public ContorolerMove(Transform t,Animator animator,Value moveSpeed){
        transform = t;
        direction = new Direction(animator);
        movespeed = moveSpeed;
    }

    public override void Check(){
        if(Input.GetKey(KeyCode.S)){
            direction.Down();
            Down();
        }
        if(Input.GetKey(KeyCode.W)){
            direction.Up();
            Up();
        }
        if(Input.GetKey(KeyCode.D)){
            direction.Right();
            Right();
        }
        if(Input.GetKey(KeyCode.A)){
            direction.Left();
            Left();
        }
    }
}