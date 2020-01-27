using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CameraManager
{
  private static GameObject MainCamera;
  private static int CameraSizeX ;
  private static int CameraSizeY ;
  private static int CameraMoveX ;
  private static int CameraMoveY ;
  private static int count;
  private static bool CameraMoveOn ;
  private static int CameraMoveXCount ;
  private static int CameraMoveYCount ;
  private static int PlayerMoveCount ;

  public static void SetUp(){
    MainCamera = Camera.main.gameObject;
    CameraSizeX = 640;
    CameraSizeY = 480;
    CameraMoveX = 0;
    CameraMoveY = 0;
    count = 0;
    CameraMoveOn = false;
    CameraMoveXCount = 0;
    CameraMoveYCount = 0;
    PlayerMoveCount = 10;
  }
  public static void PlayerPosCheck(){
    if(!CameraMoveOn){
      Vector3 Camerapos = MainCamera.transform.position;
      Vector3 Playerpos = PlayerManager.ReturnPosition();
      if(Camerapos.x+CameraSizeX/2<Playerpos.x){//カメラを右に移動する
        CameraMoveX = 1;
        CameraMoveXCount++;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          PlayerManager.PlayerMove(2);
          i--;
        }
        GameManager.StateSet("MapMove");
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
        GameManager.StateSet("MapMove");
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
        GameManager.StateSet("MapMove");
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
        GameManager.StateSet("MapMove");
      }
    }
    CameraMoveStart();
  }

　public static void CameraMoveStart(){
    if(count > CameraSizeX&&!(CameraMoveX == 0)&&CameraMoveOn){
      GameManager.StateSet("Main");
      CameraMoveOn = false;
      CameraMoveX = 0;
      count = 0;
    }
    if(count > CameraSizeY&&!(CameraMoveY == 0)&&CameraMoveOn){
      GameManager.StateSet("Main");
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
