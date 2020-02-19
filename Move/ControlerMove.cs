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
            Down();
        }
        if(Input.GetKey(KeyCode.W)){
            Up();
        }
        if(Input.GetKey(KeyCode.D)){
            Right();
        }
        if(Input.GetKey(KeyCode.A)){
            Left();
        }
    }
}