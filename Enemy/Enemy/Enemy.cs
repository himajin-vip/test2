using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Charactor
{

  


  void OnCollisionStay2D(Collision2D collision2){

  }
  private IEnumerator DestroyEnemy(){
    yield return new WaitForSeconds(0.5f);
    Destroy(this.gameObject);//hpが０になったら死ぬ
  }

  public void DestroyMapMove(){
    Destroy(this.gameObject);
  }
}
