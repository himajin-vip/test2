using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SougenMap : Map
{
  public GameObject MapObject;

  public void Start(int LastMap)
  {
    GameManager.StateSet("Main");
    GameObject obj;
    switch(LastMap){
      case 0:
        obj = (GameObject)Resources.Load("Map/草原Map");
        MapObject = GameManager.Instantiate(obj, new Vector3(PlayerManager.ReturnPosition().x,PlayerManager.ReturnPosition().y+664,0), Quaternion.identity);
        //////カメラサイズの半分-キャラサイズの半分-タイルチップのサイズ-タイルチップの半分
        CameraManager.PotisionSet(PlayerManager.ReturnPosition().x,PlayerManager.ReturnPosition().y+(240-24-32-16));
      break;

      case 1:
        obj = (GameObject)Resources.Load("Map/草原Map");
        MapObject = GameManager.Instantiate(obj, new Vector3(PlayerManager.ReturnPosition().x,PlayerManager.ReturnPosition().y,0), Quaternion.identity);
      break;
    }
  }
  public void Event(int EventNo){
    switch(EventNo){
      case 0:
        MapManager.MapChange(0);
        GameManager.StateSet("Town");
      break;
    }
  }

  public void End(){
    GameManager.Destroy (MapObject);
    EnemyManager.AllDestroy();
  }
}
