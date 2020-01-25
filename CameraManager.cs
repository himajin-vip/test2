using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
  public GameObject MainCamera;
  public int CameraSizeX = 640;
  public int CameraSizeY = 480;
  public int CameraMoveX = 0;
  public int CameraMoveY = 0;
  public int count = 0;
  public bool CameraMoveOn;
  public int CameraMoveXCount = 0;
  public int CameraMoveYCount = 0;
    void Update()
    {
      PlayerCheck();
      CameraMoveStart();
    }
  public void PlayerCheck(){
    if(!CameraMoveOn){
      Vector3 Camerapos = MainCamera.transform.position;
      Vector3 Playerpos = PlayerManager.Player.transform.position;
      if(Camerapos.x+CameraSizeX/2<Playerpos.x){
        CameraMoveX = 1;
        CameraMoveXCount++;
        CameraMoveOn = true;
      }
      if(Camerapos.x-CameraSizeX/2>Playerpos.x){
        CameraMoveX = -1;
        CameraMoveXCount--;
        CameraMoveOn = true;
      }
      if(Camerapos.y+CameraSizeY/2<Playerpos.y){
        CameraMoveY = 1;
        CameraMoveYCount++;
        CameraMoveOn = true;
      }
      if(Camerapos.y-CameraSizeY/2>Playerpos.y){
        CameraMoveY = -1;
        CameraMoveYCount--;
        CameraMoveOn = true;
      }
    }
  }

　public void CameraMoveStart(){
    if(count > CameraSizeX&&!(CameraMoveX == 0)){
      CameraMoveOn = false;
      CameraMoveX = 0;
      count = 0;
      Debug.Log("test");
    }
    if(count > CameraSizeY&&!(CameraMoveY == 0)){
      CameraMoveOn = false;
      CameraMoveY = 0;
      count = 0;
      Debug.Log("test2");
    }
    Debug.Log("loop");
    if(CameraMoveOn){
      if(CameraMoveX > 0){
        Vector3 Camerapos = MainCamera.transform.position;
        Camerapos.x+=10;
        MainCamera.transform.position = Camerapos;
      }
      if(CameraMoveX < 0){
        Vector3 Camerapos = MainCamera.transform.position;
        Camerapos.x-=10;
        MainCamera.transform.position = Camerapos;
      }
      if(CameraMoveY > 0){
        Vector3 Camerapos = MainCamera.transform.position;
        Camerapos.y+=10;
        MainCamera.transform.position = Camerapos;
      }
      if(CameraMoveY < 0){
        Vector3 Camerapos = MainCamera.transform.position;
        Camerapos.y-=10;
        MainCamera.transform.position = Camerapos;
      }
      Debug.Log("loop2");
      count+=10;
      Debug.Log(count);
      }
  }
}
