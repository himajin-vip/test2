using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager
{
  private static GameObject MainCamera;
  private static GameObject PlayerObj;
  private static Player Player;
  private static int CameraSizeX ;
  private static int CameraSizeY ;
  private static int CameraMoveX ;
  private static int CameraMoveY ;
  private static int count;
  private static bool CameraMoveOn ;
  private static int CameraMoveXCount ;
  private static int CameraMoveYCount ;
  private static int PlayerMoveCount ;

  public void SetUp(){
    MainCamera = Camera.main.gameObject;
    Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    PlayerObj = GameObject.FindGameObjectWithTag("Player").gameObject;
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

  public void PlayerPosCheck(){


    if(!CameraMoveOn){
      Vector3 Camerapos = MainCamera.transform.position;
      Vector3 Playerpos = PlayerObj.transform.position;
      if(Camerapos.x+CameraSizeX/2<Playerpos.x){//カメラを右に移動する
        CameraMoveX = 1;
        CameraMoveXCount++;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          Player.Move(2);
          i--;
        }
        GameManager.SetState("MapMove");
        MapManager.MapMove(2);
      }
      if(Camerapos.x-CameraSizeX/2>Playerpos.x){//カメラを左に移動する
        CameraMoveX = -1;
        CameraMoveXCount--;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          Player.Move(3);
          i--;
        }
        GameManager.SetState("MapMove");
        MapManager.MapMove(3);
      }
      if(Camerapos.y+CameraSizeY/2<Playerpos.y){//カメラを上に移動する
        CameraMoveY = 1;
        CameraMoveYCount++;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          Player.Move(1);
          i--;
        }
        GameManager.SetState("MapMove");
        MapManager.MapMove(1);
      }
      if(Camerapos.y-CameraSizeY/2>Playerpos.y){//カメラを下に移動する
        CameraMoveY = -1;
        CameraMoveYCount--;
        CameraMoveOn = true;
        int i = PlayerMoveCount;
        while(i>0){
          Player.Move(0);
          i--;
        }
        GameManager.SetState("MapMove");
        MapManager.MapMove(0);
      }
    }
    CameraMoveStart();
  }

　public void CameraMoveStart(){
    if(count >= CameraSizeX&&!(CameraMoveX == 0)&&CameraMoveOn){
      GameManager.SetState("Main");
      CameraMoveOn = false;
      CameraMoveX = 0;
      count = 0;
    }
    if(count >= CameraSizeY&&!(CameraMoveY == 0)&&CameraMoveOn){
      GameManager.SetState("Main");
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
  public void PotisionSet(float x,float y){
    Vector3 Camerapos = MainCamera.transform.position;
    Camerapos.x = x;
    Camerapos.y = y;
    MainCamera.transform.position = Camerapos;
  }
}
