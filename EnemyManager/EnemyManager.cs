using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EnemyManager
{
  private static Dictionary<int,Enemy> EnemyList = new Dictionary<int,Enemy>();
  private static List<int> EnemyIdList =new List<int>();
  private static int EnemyMaxCount;
  private static int EnemyCurrentCount;
  private static GameObject SlimePlefab;

  public static void SetUp(){
    EnemyList.Clear();
    EnemyIdList.Clear();
    EnemyMaxCount = 3;
    EnemyCurrentCount = 0;

    for(int i = 0 ;i<=EnemyMaxCount;i++){
      EnemyIdList.Add(i);
    }

  }
  public static void MakeEnemy(string enemyname){
    float CameraposX = CameraManager.ReturnPosition().x;
    float CameraposY = CameraManager.ReturnPosition().y;
    int CameraSizeX = 640;
    int CameraSizeY = 480;
    int marge = 64;

    if(EnemyMaxCount>=EnemyCurrentCount){
      int x = Random.Range(-CameraSizeX/2+marge,CameraSizeX/2-marge);
      int y =  Random.Range(-CameraSizeY/2+marge,CameraSizeY/2-marge);
      GameObject Enemyobj = (GameObject)Resources.Load("prefab/Enemy/"+enemyname);
      GameObject Enemyobj2= GameManager.Instantiate(Enemyobj,new Vector3(CameraposX+x,CameraposY+y,0), Quaternion.identity);
      Enemy Slime = Enemyobj2.GetComponent<Enemy>();
      int useid = 0;
      foreach(int id in EnemyIdList){
        Slime.EnemyId = id;
        useid = id;
      }
      EnemyIdList.Remove(useid);
      EnemyList.Add(useid,Slime);
      EnemyCurrentCount++;
    }
  }
  public static void EnemyUpdate(){
    List<Enemy> DeathList = new List<Enemy>();
    foreach (Enemy enemy in EnemyList.Values){
        if(enemy.CurrentHp<=0&&!enemy.DeathCheck){
          DeathList.Add(enemy);
      }else{
        enemy.Move();
      }
    }

    foreach(Enemy enemy in DeathList){
      enemy.Death();
      EnemyList.Remove(enemy.EnemyId);
      EnemyIdList.Add(enemy.EnemyId);
      EnemyCurrentCount--;
    }
  }
    public static void AllDestroy(){
      foreach (Enemy enemy in EnemyList.Values){
        enemy.DestroyMapMove();
      }
      EnemyList.Clear();
      EnemyIdList.Clear();
      EnemyCurrentCount = 0;

      for(int i = 0 ;i<=EnemyMaxCount;i++){
        EnemyIdList.Add(i);
      }

  }
}
