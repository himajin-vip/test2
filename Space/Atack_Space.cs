using UnityEngine;
public class Atack_Space:SpaceOn
{
    public void KeyDown(){
        GameManager.SetState(States.ChargeSet ,new StateData());
    }
    public void KeyUp(){
        GameManager.SetState(States.AtackState,new StateData());
    }
}