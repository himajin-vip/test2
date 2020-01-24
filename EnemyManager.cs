using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
  public GameObject slime;
  private static int enemyMaxCount = 5;
  private static int enemyCurrentCount;

  public static void MakeEnemy(string enemyname){
      int MapSizeX = 640;
      int MapSizeY = 480;
      int marge = 64;
      if(enemyMaxCount>enemyCurrentCount){
        GameObject Enemy = (GameObject)Resources.Load ("prefab/Enemy/"+enemyname);
        int x = Random.Range(-MapSizeX/2+marge,MapSizeX/2-marge);
        int y =  Random.Range(-MapSizeY/2+marge,MapSizeY/2-marge);
        Instantiate(Enemy,new Vector3(x,y,0), Quaternion.identity);
        enemyCurrentCount++;
      }
    }
    public static int EnemyCurrentCount{
        set { enemyCurrentCount = value; }
        get { return enemyCurrentCount; }
    }

    public static int EnemyMaxCount{
        set { enemyMaxCount = value; }
        get { return enemyMaxCount; }
    }
}
