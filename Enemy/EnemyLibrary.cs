using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyLibrary
{
  private static Dictionary<Enemys,GameObject> EnemyList = new Dictionary<Enemys ,GameObject>();

  public void SetUp(){
    foreach(Enemys enemy in Enum.GetValues(typeof(Enemys))){
      EnemyList.Add(enemy,(GameObject)Resources.Load("prefab/Enemy/"+enemy.ToString()));
    }

  }
  public GameObject MakeEnemy(Enemys enemy){
    int MapSizex = 640;
    int MapSizey = 384;
    int objectSize = 32;
    float Camerax = Camera.main.transform.position.x;
    float Cameray = Camera.main.transform.position.y;
    float Max_x = Camerax+(MapSizex/2)-objectSize;
    float Min_x = Camerax-(MapSizex/2)+objectSize;
    float Max_y = Cameray+(MapSizey/2)-objectSize;
    float Min_y = Cameray-(MapSizey/2)+objectSize;
    float Randomx = UnityEngine.Random.Range(Min_x,Max_x);
    float Randomy = UnityEngine.Random.Range(Min_y,Max_y);
    return GameManager.Instantiate(EnemyList[enemy],new Vector3(Randomx,Randomy,0),Quaternion.identity);
  }



}
