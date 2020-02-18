using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager
{
  private static Dictionary<int,Enemy> EnemyList = new Dictionary<int,Enemy>();
  private static Dictionary<int,GameObject> EnemyTypeList = new Dictionary<int ,GameObject>();
  private static List<int> EnemyIdList =new List<int>();
  private static int EnemyMaxCount;
  private static int EnemyCurrentCount;
  private static GameObject SlimePlefab;
  private static List<int> MapEnemyTypeList = new List<int>();
  private static int MapEnemyTypeCount;

  public void SetUp(){
    EnemyTypeList.Clear();
    EnemyList.Clear();
    EnemyIdList.Clear();
    MapEnemyTypeList.Clear();
    
    EnemyTypeList.Add(0,(GameObject)Resources.Load("prefab/Enemy/Slime"));
    EnemyTypeList.Add(1,(GameObject)Resources.Load("prefab/Enemy/RedSlime"));
    EnemyTypeList.Add(2,(GameObject)Resources.Load("prefab/Enemy/BigSlime"));
    EnemyTypeList.Add(3,(GameObject)Resources.Load("prefab/Enemy/KingSlime"));

    EnemyCurrentCount = 0;
  }

  public static void MapEnemyDataSet(){
    MapEnemyList MapEnemyList = MapManager.ReturnEnemyList();
    EnemyMaxCount = MapEnemyList.EnemyCount;
    MapEnemyTypeList = MapEnemyList.EnemyType;
    MapEnemyTypeCount = MapEnemyTypeList.Count;
    for(int i = 0 ;i<=EnemyMaxCount;i++){
      EnemyIdList.Add(i);
    }
  }

  public static void MakeEnemy(){

    float CameraposX = Camera.main.gameObject.transform.position.x;
    float CameraposY = Camera.main.gameObject.transform.position.y;
    int CameraSizeX = 640;
    int CameraSizeY = 480;
    int marge = 64;

    if(EnemyMaxCount>EnemyCurrentCount){

      ///////出現する敵の決定
      int EnemyTypeNo = Random.Range(0,MapEnemyTypeCount);
      int EnemyType = MapEnemyTypeList[EnemyTypeNo];
      GameObject EnemyObject = EnemyTypeList[EnemyType];

      ///////座標の決定
      int x = Random.Range(-CameraSizeX/2+marge,CameraSizeX/2-marge);
      int y =  Random.Range(-CameraSizeY/2+marge,CameraSizeY/2-marge);

      ///////オブジェクトの作成;
      GameObject Enemyobj2= GameManager.Instantiate(EnemyObject,new Vector3(CameraposX+x,CameraposY+y,0), Quaternion.identity);
      Enemy Enemy = Enemyobj2.GetComponent<Enemy>();
      Enemy.SetUp();
      ////////ID決め
      int useid = 0;
      foreach(int id in EnemyIdList){
        Enemy.EnemyId = id;
        useid = id;
      }
      EnemyIdList.Remove(useid);
      EnemyList.Add(useid,Enemy);

      /////最後の処理
      EnemyCurrentCount++;
    }
  }
  public static void EnemyUpdate(){
    List<Enemy> DeathList = new List<Enemy>();
    foreach (Enemy enemy in EnemyList.Values){
      //   if(enemy.Hp.currentValue<=0&&!enemy.DeathCheck){
      //     DeathList.Add(enemy);
      // }else{
      //   enemy.Move();
      // }
    }

    foreach(Enemy enemy in DeathList){
      // enemy.Death();
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

      for(int i = 0 ;i<EnemyMaxCount;i++){
        EnemyIdList.Add(i);
      }

  }
}
