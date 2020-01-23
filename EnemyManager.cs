using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
  public GameObject slime;
  int EnemyMaxCount;
  public int EnemyCurrentCount=0;
  int MapSizeX = 640;
  int MapSizeY = 480;
    // Start is called before the first frame update
    void Start()
    {
      SetEnemyMaxCount(4);
    }

    // Update is called once per frame
    void Update()
    {
      MakeEnemy();
    }
    void MakeEnemy(){
      if(EnemyMaxCount>EnemyCurrentCount){
        int x = Random.Range(-MapSizeX/2+64,MapSizeX/2-64);
        int y =  Random.Range(-MapSizeY/2+64,MapSizeY/2-64);
        Instantiate(slime,new Vector3(x,y,0), Quaternion.identity);
        EnemyCurrentCount++;
      }
    }

    void SetEnemyMaxCount(int count){
      EnemyMaxCount = count;
    }
}
