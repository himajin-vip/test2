﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMap1 : Map
{
  public GameObject MapObject;

  public void Start(int LastMap)
  {
    GameObject obj;
    switch(LastMap){
      case 0:
        obj = (GameObject)Resources.Load("Map/TestMap");
        MapObject = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
      break;

      case 1:
        obj = (GameObject)Resources.Load("Map/TestMap");
        MapObject = GameManager.Instantiate(obj, new Vector3(PlayerManager.ReturnPosition().x,PlayerManager.ReturnPosition().y-240+24+32), Quaternion.identity);
        CameraManager.PotisionSet(PlayerManager.ReturnPosition().x,PlayerManager.ReturnPosition().y+(-240+24+32+16));
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

  public void End(){
    GameManager.Destroy (MapObject);
  }
}
