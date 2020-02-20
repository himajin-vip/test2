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
    float Camerax = Camera.main.transform.position.x;
    float Cameray = Camera.main.transform.position.y;
    float Max_x = Camerax+320;
    float Min_x = Camerax-320;
    float Max_y = Cameray+240;
    float Min_y = Cameray-240;
    float Randomx = UnityEngine.Random.Range(Min_x,Max_x);
    float Randomy = UnityEngine.Random.Range(Min_y,Max_y);
    return GameManager.Instantiate(EnemyList[enemy],new Vector3(Randomx,Randomy,0),Quaternion.identity);
  }



}
