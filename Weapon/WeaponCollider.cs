
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponCollider : MonoBehaviour
{
  Weapon weapon;

  public void SetUp(Weapon w){
    weapon = w;
  }

  void OnTriggerEnter2D(Collider2D collision2){
    if(collision2.gameObject.GetComponent<Enemy>()){
      Enemy HitEnemy = collision2.gameObject.GetComponent<Enemy>();
      weapon.Hit(HitEnemy);
    }
  }


}
