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
  private static bool CameraMoveOn = false;
  private static int CameraMoveXCount = 0;
  private static int CameraMoveYCount = 0;
  private static int PlayerMoveCount = 5;

  public static void SetUp(){
    MainCamera = Camera.main.gameObject;
  }
  public static void PlayerPosCheck(){
    if(!CameraMoveOn){
      Vector3 Camerapos = MainCamera.transform.position;
      Vector3 Playerpos = PlayerManager.Player.transform.position;
      if(Camerapos.x+CameraSizeX/2<Playerpos.x){//カメラを右に移動する
        CameraMoveX = 1;
        CameraMoveXCount++;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          PlayerManager.PlayerMove(2);
          i--;
        }
        UpdateManager.StateSet("MapMove");
      }
      if(Camerapos.x-CameraSizeX/2>Playerpos.x){//カメラを左に移動する
        CameraMoveX = -1;
        CameraMoveXCount--;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          PlayerManager.PlayerMove(3);
          i--;
        }
        UpdateManager.StateSet("MapMove");
      }
      if(Camerapos.y+CameraSizeY/2<Playerpos.y){//カメラを上に移動する
        CameraMoveY = 1;
        CameraMoveYCount++;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          PlayerManager.PlayerMove(1);
          i--;
        }
        UpdateManager.StateSet("MapMove");
      }
      if(Camerapos.y-CameraSizeY/2>Playerpos.y){//カメラを下に移動する
        CameraMoveY = -1;
        CameraMoveYCount--;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          PlayerManager.PlayerMove(0);
          i--;
        }
        UpdateManager.StateSet("MapMove");
      }
    }
    CameraMoveStart();
  }

　public static void CameraMoveStart(){
    if(count > CameraSizeX&&!(CameraMoveX == 0)&&CameraMoveOn){
      UpdateManager.StateSet("Main");
      CameraMoveOn = false;
      CameraMoveX = 0;
      count = 0;
    }
    if(count > CameraSizeY&&!(CameraMoveY == 0)&&CameraMoveOn){
      UpdateManager.StateSet("Main");
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
