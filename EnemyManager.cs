using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
  public static GameObject Slime;
  public static int EnemyMaxCount = 0;
  public static int EnemyCurrentCount;

  public static void MakeEnemy(string enemyname){
      int MapSizeX = 640;
      int MapSizeY = 480;
      int marge = 64;
      if(EnemyMaxCount>=EnemyCurrentCount){
        int x = Random.Range(-MapSizeX/2+marge,MapSizeX/2-marge);
        int y =  Random.Range(-MapSizeY/2+marge,MapSizeY/2-marge);
        GameObject Enemy = (GameObject)Resources.Load("prefab/Enemy/"+enemyname);
        Slime = Instantiate(Enemy,new Vector3(x,y,0), Quaternion.identity);
        EnemyCurrentCount++;
      }
    }
}
