using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEnemyList
{
    public int EnemyCount;
    public List<int> EnemyType = new List<int>();

    public MapEnemyList(List<int> enemytype,int enemycount){
      EnemyCount = enemycount;
      EnemyType = enemytype;
    }
}
