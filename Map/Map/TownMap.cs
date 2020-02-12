using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownMap : Map
{
  private GameObject MapObject;
  private MapEnemyList EnemyList = new MapEnemyList(new List<int>(),0);

  public void SetUp(){
  }
  public void Start(int LastMap)
  {
    GameObject PlayerObj = GameObject.FindGameObjectWithTag("Player").gameObject;
    GameObject obj;
    CameraManager cameraManager = new CameraManager();
    switch(LastMap){
      case 0:
        obj = (GameObject)Resources.Load("Map/TownMap");
        MapObject = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
      break;

      case 1:
        obj = (GameObject)Resources.Load("Map/TownMap");
        MapObject = GameManager.Instantiate(obj, new Vector3(PlayerObj.transform.position.x,PlayerObj.transform.position.y-240+24+32), Quaternion.identity);
        cameraManager.PotisionSet(PlayerObj.transform.position.x,PlayerObj.transform.position.y+(-240+24+32+16));
      break;
    }
  }
  public void Event(int EventNo){
    switch(EventNo){
      case 0:
        MapManager.MapChange(1);
        MapObject.SetActive(false);
      break;
    }
  }
  public void MapMove(int Direction){
    switch (Direction){
      case 0:
      break;
      case 1:
      break;
      case 2:
      break;
      case 3:
      break;
    }
  }
  public MapEnemyList ReturnEnemyList(){
    return EnemyList;
  }

  public void End(){
    GameManager.Destroy (MapObject);
  }
}
