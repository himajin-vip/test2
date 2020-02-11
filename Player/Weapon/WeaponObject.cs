
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponObject : MonoBehaviour
{
  public int Damage;
  public static Dictionary<int,Enemy> HitEnemyList = new Dictionary<int,Enemy>();
  public int HitCount = 0;

  public void SetUp(){
    HitEnemyList.Clear();
  }

  public void OnEnd(){
    GameManager.Player.Skill.Damage(HitEnemyList);
    HitEnemyList.Clear();
    GameManager.Player.Atack.Off();
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
