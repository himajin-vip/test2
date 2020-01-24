using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
  public GameObject slime;
  static int EnemyMaxCount = 5;
  static int EnemyCurrentCount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      MakeEnemy("slime");
    }
    static void MakeEnemy(string enemyname){
      int MapSizeX = 640;
      int MapSizeY = 480;
      int marge = 64;
      if(EnemyMaxCount>EnemyCurrentCount){
        GameObject Enemy = (GameObject)Resources.Load ("prefab/Enemy/"+enemyname);
        int x = Random.Range(-MapSizeX/2+marge,MapSizeX/2-marge);
        int y =  Random.Range(-MapSizeY/2+marge,MapSizeY/2-marge);
        Instantiate(Enemy,new Vector3(x,y,0), Quaternion.identity);
        EnemyCurrentCount++;
      }
    }
    public static void DethEnemy(){
      EnemyCurrentCount--;
    }

    static void SetEnemyMaxCount(int count){
      EnemyMaxCount = count;
    }
}
