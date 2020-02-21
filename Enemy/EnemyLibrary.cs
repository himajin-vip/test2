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
    float Randomx = UnityEngine.Random.Range(new MapPosition().MinX,new MapPosition().MaxX);
    float Randomy = UnityEngine.Random.Range(new MapPosition().MinY,new MapPosition().MaxY);
    return GameManager.Instantiate(EnemyList[enemy],new Vector3(Randomx,Randomy,0),Quaternion.identity);
  }



}
