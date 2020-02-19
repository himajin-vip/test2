using UnityEngine;
public class CameraMove:Move
{
    Transform PlayerTransform;
    CameraMoveValue CameraMoveValue = new CameraMoveValue();
    public CameraMove(Transform playertransform){
        transform = Camera.main.gameObject.transform;
        PlayerTransform = playertransform;
        movespeed = new IntValue(10);
    }
    public override void Check(){
        if(!CameraMoveValue.On()){
            PlayerPosCheck();
        }
        if(CameraMoveValue.On()){
            CameraMoveValue.Count();
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
    public void PlayerPosCheck(){
        float cameraposx = transform.position.x;
        float cameraposy = transform.position.y;
        float playerposx = PlayerTransform.position.x;
        float playerposy = PlayerTransform.position.y;
        float CameraSizeRight = cameraposx+320;
        float CameraSizeLeft = cameraposx-320;
        float CameraSizeUp = cameraposy+240;
        float CameraSizeDown = cameraposy-240;
        
        if(CameraSizeRight<playerposx){
            CameraMoveValue.Set(2,64);
            PlayerTransform.Translate(20,0,0);
            return;
        }
        if(CameraSizeLeft>playerposx){
            CameraMoveValue.Set(3,64);
            PlayerTransform.Translate(-20,0,0);
            return;
        }
        if(CameraSizeUp < playerposy){
            CameraMoveValue.Set(1,48);
            PlayerTransform.Translate(0,30,0);
            return;
        }
        if(CameraSizeDown > playerposy){
            CameraMoveValue.Set(0,48);
            PlayerTransform.Translate(0,-20,0);
            return;
        }
    }
}