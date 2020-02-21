using UnityEngine;
public class CameraMove:Move
{
    CameraMoveValue CameraMoveValue = new CameraMoveValue();
    PlayerPosCheck PlayerPosCheck;
    public CameraMove(Transform playertransform){
        transform = Camera.main.gameObject.transform;
        PlayerPosCheck = new PlayerPosCheck(playertransform,CameraMoveValue);
        movespeed = new IntValue(10);
    }
    public override void Check(){
        if(PlayerPosCheck.Check()&&!CameraMoveValue.On()){
            GameManager.SetState(States.MapMove,new StateData());
            CameraMoveValue.SetOn();
        }
        if(CameraMoveValue.On()){
            CameraMoveValue.Count();
        }
        if(CameraMoveValue.On()){
            CountMove();
        }
    }
    public void CountMove(){
        switch(CameraMoveValue.GetIntValue()){
            case 0:
            Down();
            break;
            case 1:
            Up();
            break;
            case 2:
            Right();
            break;
            case 3:
            Left();
            break;
        }
    }
}