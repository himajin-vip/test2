using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyatack : MonoBehaviour
{
  public Enemy enemy;


    public void atack(int damage ,float x ,float y,Player Player){
        Player.DamageHp(damage);
        this.gameObject.transform.position = new Vector3(x,y,0);
        this.gameObject.SetActive(true);
    }



    public void end(){
      this.gameObject.SetActive(false);
    }
}
