using UnityEngine;
public class Atack_Space:SpaceOn
{
    public void KeyDown(){
        //チャージする



    }
    public void KeyUp(){
        GameManager.SetState(States.AtackState);
    }
}