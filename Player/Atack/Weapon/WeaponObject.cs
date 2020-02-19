
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponObject : MonoBehaviour
{

  private static Dictionary<int,Enemy> HitEnemyList = new Dictionary<int,Enemy>();
  private int HitCount = 0;

  private Playerp Playerp;


  public void OnEnd(){
    Destroy (this.gameObject);
  }

  void OnTriggerEnter2D(Collider2D collision2){
    if(collision2.gameObject.GetComponent<Enemy>()){

      Enemy HitEnemy = collision2.gameObject.GetComponent<Enemy>();
      bool NewEnemy = true;

      if(HitCount == 0){
        HitCount++;
        HitEnemyList.Add(HitEnemy.EnemyId,HitEnemy);
      }else{
        foreach(Enemy enemy in HitEnemyList.Values){
          if(enemy.EnemyId==HitEnemy.EnemyId){
            NewEnemy = false;
          }
        }
        if(NewEnemy){
          HitEnemyList.Add(HitEnemy.EnemyId,HitEnemy);
        }
      }
    }
  }

}
