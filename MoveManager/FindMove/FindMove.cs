using UnityEngine;
public class FindMove:Move
{
    Transform Target;
    Direction direction;
    public FindMove(Transform t,Animator animator,Value moveSpeed,Transform target){
        transform = t;
        direction = new Direction(animator);
        movespeed = moveSpeed;
        Target = target;
    }
    public override void Check(){
        if(transform.position.x > Target.position.x){
            direction.Left();
            Left();
        }
        if(transform.position.x < Target.position.x){
            direction.Right();
            Right();
        }
        if(transform.position.y > Target.position.y){
            direction.Down();
            Down();
        }
        if(transform.position.y < Target.position.y){
            direction.Up();
            Up();
        }
    }

}