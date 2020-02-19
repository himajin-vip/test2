using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HitEnemyCheck
{
    public HitEnemyCheck(List<Enemy> HitList,Enemy HitEnemy){
      if(!HitList.Contains(HitEnemy)){
          HitList.Add(HitEnemy);
      }
  }
}