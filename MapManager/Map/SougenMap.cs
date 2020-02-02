using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SougenMap : Map
{
  public GameObject MapObject;
  public MapEnemyList[,] EnemyList;////座標毎のエネミーリスト
  public int MapPositionX;
  public int MapPositionY;

  public void SetUp(){

    List<int> EnemyTypeList00 = new List<int>{0,1};
    MapEnemyList EnemyList00 = new MapEnemyList(EnemyTypeList00,3);

    List<int> EnemyTypeList10 = new List<int>{0};
    Debug.Log(EnemyTypeList10.Count);
    MapEnemyList EnemyList10 = new MapEnemyList(EnemyTypeList10,2);

    List<int> EnemyTypeList20 = new List<int>{1};
    MapEnemyList EnemyList20 = new MapEnemyList(EnemyTypeList20,3);

    List<int> EnemyTypeList01 = new List<int>{0};
    MapEnemyList EnemyList01 = new MapEnemyList(EnemyTypeList01,4);

    List<int> EnemyTypeList11 = new List<int>{1};
    MapEnemyList EnemyList11 = new MapEnemyList(EnemyTypeList11,5);

    List<int> EnemyTypeList21 = new List<int>{0};
    MapEnemyList EnemyList21 = new MapEnemyList(EnemyTypeList21,3);

    List<int> EnemyTypeList02 = new List<int>{0};
    MapEnemyList EnemyList02 = new MapEnemyList(EnemyTypeList02,2);

    List<int> EnemyTypeList12 = new List<int>{1};
    MapEnemyList EnemyList12 = new MapEnemyList(EnemyTypeList12,8);

    List<int> EnemyTypeList22 = new List<int>{0,1};
    MapEnemyList EnemyList22 = new MapEnemyList(EnemyTypeList22,9);

    EnemyList = new MapEnemyList[3,3]{
      {EnemyList00,EnemyList10,EnemyList20},
      {EnemyList01,EnemyList11,EnemyList21},
      {EnemyList02,EnemyList12,EnemyList22}
    };
  }

  public void Start(int LastMap)
  {
    GameManager.StateSet("Main");
    GameObject obj;
    switch(LastMap){
      case 0:
        MapPositionX = 1;
        MapPositionY = 0;
        obj = (GameObject)Resources.Load("Map/草原Map");
        MapObject = GameManager.Instantiate(obj, new Vector3(PlayerManager.ReturnPosition().x,PlayerManager.ReturnPosition().y+664,0), Quaternion.identity);
        //////カメラサイズの半分-キャラサイズの半分-タイルチップのサイズ-タイルチップの半分
        CameraManager.PotisionSet(PlayerManager.ReturnPosition().x,PlayerManager.ReturnPosition().y+(240-24-32-16));
      break;
    }
    EnemyManager.MapEnemyDataSet();
  }
  public void Event(int EventNo){
    switch(EventNo){
      case 0:
        MapManager.MapChange(0);
        GameManager.StateSet("Town");
      break;
    }
  }
  public void MapMove(int Direction){
    switch (Direction){
      case 0:
        MapPositionY -= 1;
      break;
      case 1:
        MapPositionY += 1;
      break;
      case 2:
        MapPositionX += 1;
      break;
      case 3:
        MapPositionX -= 1;
      break;
    }
    Debug.Log("MapPos:X:"+MapPositionX+",Y:"+MapPositionY);
    EnemyManager.MapEnemyDataSet();
  }
  public MapEnemyList ReturnEnemyList(){
    return EnemyList[MapPositionY,MapPositionX];
  }

  public void End(){
    GameManager.Destroy (MapObject);
    EnemyManager.AllDestroy();
  }
}
