using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager
{
  private static GameObject MainCamera;
  private static GameObject PlayerpObj;
  private static Playerp Playerp;
  private static int CameraSizeX ;
  private static int CameraSizeY ;
  private static int CameraMoveX ;
  private static int CameraMoveY ;
  private static int count;
  private static bool CameraMoveOn ;
  private static int CameraMoveXCount ;
  private static int CameraMoveYCount ;
  private static int PlayerpMoveCount ;

  public void SetUp(){
    MainCamera = Camera.main.gameObject;
    Playerp = GameObject.FindGameObjectWithTag("Playerp").GetComponent<Playerp>();
    PlayerpObj = GameObject.FindGameObjectWithTag("Playerp").gameObject;
    CameraSizeX = 640;
    CameraSizeY = 480;
    CameraMoveX = 0;
    CameraMoveY = 0;
    count = 0;
    CameraMoveOn = false;
    CameraMoveXCount = 0;
    CameraMoveYCount = 0;
    PlayerpMoveCount = 10;
  }

  public void PlayerpPosCheck(){


    if(!CameraMoveOn){
      Vector3 Camerapos = MainCamera.transform.position;
      Vector3 Playerppos = PlayerpObj.transform.position;
      if(Camerapos.x+CameraSizeX/2<Playerppos.x){//カメラを右に移動する
        CameraMoveX = 1;
        CameraMoveXCount++;
        CameraMoveOn = true;
        int i = PlayerpMoveCount;
        while(i>0){
          Playerp.Move(2);
          i--;
        }
        GameManager.SetState("MapMove");
        MapManager.MapMove(2);
      }
      if(Camerapos.x-CameraSizeX/2>Playerppos.x){//カメラを左に移動する
        CameraMoveX = -1;
        CameraMoveXCount--;
        CameraMoveOn = true;
        int i = PlayerpMoveCount;
        while(i>0){
          Playerp.Move(3);
          i--;
        }
        GameManager.SetState("MapMove");
        MapManager.MapMove(3);
      }
      if(Camerapos.y+CameraSizeY/2<Playerppos.y){//カメラを上に移動する
        CameraMoveY = 1;
        CameraMoveYCount++;
        CameraMoveOn = true;
        int i = PlayerpMoveCount;
        while(i>0){
          Playerp.Move(1);
          i--;
        }
        GameManager.SetState("MapMove");
        MapManager.MapMove(1);
      }
      if(Camerapos.y-CameraSizeY/2>Playerppos.y){//カメラを下に移動する
        CameraMoveY = -1;
        CameraMoveYCount--;
        CameraMoveOn = true;
        int i = PlayerpMoveCount;
        while(i>0){
          Playerp.Move(0);
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
