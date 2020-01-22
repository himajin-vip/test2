using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyatack : MonoBehaviour
{
  public Enemy enemy;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void atack(int damage ,float x ,float y,Player_HP_Manager playerhpmanager){
      playerhpmanager.DamageHP(damage);
      this.gameObject.transform.position = new Vector3(x,y,0);
      this.gameObject.SetActive(true);
    }

    public void end(){
      enemy.atackon = false;
      this.gameObject.SetActive(false);
    }
}
