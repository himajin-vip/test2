using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EnemyManager
{
  private static GameObject Slime;
  private static int EnemyMaxCount = 10;
  private static int EnemyCurrentCount = 0;


  public static void MakeEnemy(string enemyname){
      int MapSizeX = 640*3;
      int MapSizeY = 480*3;
      int marge = 64;
      if(EnemyMaxCount>=EnemyCurrentCount){
        int x = Random.Range(-MapSizeX/2+marge,MapSizeX/2-marge);
        int y =  Random.Range(-MapSizeY/2+marge,MapSizeY/2-marge);
        GameObject Enemy = (GameObject)Resources.Load("prefab/Enemy/"+enemyname);
        Slime = GameManager.Instantiate(Enemy,new Vector3(x,y,0), Quaternion.identity);
        EnemyCurrentCount++;
      }
    }
  public static void EnemyCurrentCountDown(){
    EnemyCurrentCount--;
  }
}
