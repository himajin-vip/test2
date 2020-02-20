using UnityEngine;
public class Atack_Space:SpaceOn
{
    public void KeyDown(){
        GameManager.SetState(States.ChargeSetState);
    }
    public void KeyUp(){
        GameManager.SetState(States.AtackState);
    }
}