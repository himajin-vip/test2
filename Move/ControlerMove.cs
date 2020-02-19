using UnityEngine;
public class ContorolerMove:Move
{
    public ContorolerMove(Transform t){
        transform = t;
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