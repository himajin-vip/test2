using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CameraManager
{
  private static GameObject MainCamera;
  private static int CameraSizeX = 640;
  private static int CameraSizeY = 480;
  private static int CameraMoveX = 0;
  private static int CameraMoveY = 0;
  private static int count = 0;
  private static bool CameraMoveOn;
  private static int CameraMoveXCount = 0;
  private static int CameraMoveYCount = 0;

  public static void SetUp(){
    Debug.Log("CameraManagerを初期化します");
    MainCamera = Camera.main.gameObject;
    Debug.Log("CameraManagerを初期化完了");
  }
  public static void PlayerCheck(){
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
    CameraMoveStart();
  }

　public static void CameraMoveStart(){
    if(count > CameraSizeX&&!(CameraMoveX == 0)){
      CameraMoveOn = false;
      CameraMoveX = 0;
      count = 0;
    }
    if(count > CameraSizeY&&!(CameraMoveY == 0)){
      CameraMoveOn = false;
      CameraMoveY = 0;
      count = 0;
    }
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
      count+=10;
      }
  }
}
