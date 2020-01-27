using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EnemyManager
{
  private static List<Enemy> EnemyList = new List<Enemy>();
  private static GameObject Slime;
  private static int EnemyMaxCount = 10;
  private static int EnemyCurrentCount = 0;
  private static GameObject SlimePlefab;


  public static void MakeEnemy(string enemyname){
    int MapSizeX = 640*3;
    int MapSizeY = 480*3;
    int marge = 64;
    if(EnemyMaxCount>=EnemyCurrentCount){
      int x = Random.Range(-MapSizeX/2+marge,MapSizeX/2-marge);
      int y =  Random.Range(-MapSizeY/2+marge,MapSizeY/2-marge);
      GameObject Enemy = (GameObject)Resources.Load("prefab/Enemy/"+enemyname);
      Slime = GameManager.Instantiate(Enemy,new Vector3(x,y,0), Quaternion.identity);
      EnemyList.Add(Slime.GetComponent<Enemy>());
      EnemyCurrentCount++;
    }
  }
  public static void EnemyUpdate(){
    foreach (Enemy enemy in EnemyList){
        enemy.Move();
        if(enemy.CurrentHp<=0&&!enemy.DeathCheck){
          enemy.Death();
          EnemyCurrentCount--;
      }
    }
  }
}
