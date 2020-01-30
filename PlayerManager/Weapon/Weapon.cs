
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weapon : MonoBehaviour
{
  public int Damage;
  public static Dictionary<int,Enemy> HitEnemyList = new Dictionary<int,Enemy>();
  public int HitCount = 0;


  public void OnEnd(){
    Destroy (this.gameObject);
    PlayerManager.AtackOff();
    PlayerManager.AtackDamageCheck(HitEnemyList);
    HitEnemyList.Clear();
  }

  void OnTriggerEnter2D(Collider2D collision2){
    if(collision2.gameObject.GetComponent<Enemy>()){

      Enemy HitEnemy = collision2.gameObject.GetComponent<Enemy>();
      bool NewEnemy = false;

      if(HitCount == 0){
        HitCount++;
        Debug.Log("AddList:"+HitEnemy.EnemyId);
        HitEnemyList.Add(HitEnemy.EnemyId,HitEnemy);
      }

      foreach(Enemy enemy in HitEnemyList.Values){
        if(enemy.EnemyId!=HitEnemy.EnemyId){
          NewEnemy = true;
        }
      }
      if(NewEnemy){
        HitEnemyList.Add(HitEnemy.EnemyId,HitEnemy);
      }
    }
  }

}
