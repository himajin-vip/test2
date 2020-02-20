using UnityEngine;
public class PlayerPosCheck{
    private Transform PlayerTransform;
    private Transform CameraTransform;
    private CameraMoveValue CameraMoveValue;
    public PlayerPosCheck(Transform playertransform,CameraMoveValue cameraMove){
        PlayerTransform = playertransform;
        CameraTransform = Camera.main.gameObject.transform;
        CameraMoveValue = cameraMove;
    }
    public bool Check(){
        if(!CameraMoveValue.On()){
            float cameraposx = CameraTransform.position.x;
            float cameraposy = CameraTransform.position.y;
            float playerposx = PlayerTransform.position.x;
            float playerposy = PlayerTransform.position.y;
            float CameraSizeRight = cameraposx+320;
            float CameraSizeLeft = cameraposx-320;
            float CameraSizeUp = cameraposy+240;
            float CameraSizeDown = cameraposy-240;
            
            if(CameraSizeRight<playerposx){
                CameraMoveValue.Set(2,64);
                PlayerTransform.Translate(20,0,0);
                return true;
            }
            if(CameraSizeLeft>playerposx){
                CameraMoveValue.Set(3,64);
                PlayerTransform.Translate(-20,0,0);
                return true;
            }
            if(CameraSizeUp < playerposy){
                CameraMoveValue.Set(1,48);
                PlayerTransform.Translate(0,30,0);
                return true;
            }
            if(CameraSizeDown > playerposy){
                CameraMoveValue.Set(0,48);
                PlayerTransform.Translate(0,-20,0);
                return true;
            }
        }
        return false;
    }
}