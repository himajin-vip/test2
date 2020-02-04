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
  public static Vector3 ReturnPosition(){
    return MainCamera.transform.position;
  }
  public static void PlayerPosCheck(){
    if(!CameraMoveOn){
      Vector3 Camerapos = MainCamera.transform.position;
      Vector3 Playerpos = PlayerManager.Player.GameObject.transform.position;
      if(Camerapos.x+CameraSizeX/2<Playerpos.x){//カメラを右に移動する
        CameraMoveX = 1;
        CameraMoveXCount++;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          PlayerManager.Player.MoveRight();
          i--;
        }
        GameManager.StateSet("MapMove");
        MapManager.MapMove(2);
      }
      if(Camerapos.x-CameraSizeX/2>Playerpos.x){//カメラを左に移動する
        CameraMoveX = -1;
        CameraMoveXCount--;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          PlayerManager.Player.MoveLeft();
          i--;
        }
        GameManager.StateSet("MapMove");
        MapManager.MapMove(3);
      }
      if(Camerapos.y+CameraSizeY/2<Playerpos.y){//カメラを上に移動する
        CameraMoveY = 1;
        CameraMoveYCount++;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          PlayerManager.Player.MoveUp();
          i--;
        }
        GameManager.StateSet("MapMove");
        MapManager.MapMove(1);
      }
      if(Camerapos.y-CameraSizeY/2>Playerpos.y){//カメラを下に移動する
        CameraMoveY = -1;
        CameraMoveYCount--;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          PlayerManager.Player.MoveDown();
          i--;
        }
        GameManager.StateSet("MapMove");
        MapManager.MapMove(0);
      }
    }
    CameraMoveStart();
  }

　public static void CameraMoveStart(){
    if(count >= CameraSizeX&&!(CameraMoveX == 0)&&CameraMoveOn){
      GameManager.StateSet("Main");
      CameraMoveOn = false;
      CameraMoveX = 0;
      count = 0;
    }
    if(count >= CameraSizeY&&!(CameraMoveY == 0)&&CameraMoveOn){
      GameManager.StateSet("Main");
      CameraMoveOn = false;
      CameraMoveY = 0;
      count = 0;
    }
    if(CameraMoveOn){
      EnemyManager.AllDestroy();
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
  public static void PotisionSet(float x,float y){
    Vector3 Camerapos = MainCamera.transform.position;
    Camerapos.x = x;
    Camerapos.y = y;
    MainCamera.transform.position = Camerapos;
  }
}
