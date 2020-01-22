using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bukimanager : MonoBehaviour
{
  public int damage ;
  public Animator buki_animator;
  public AtackManager atackmanager;
  public MoveManager movemanager;
  public bool atack_hit;
  public EfectManager efectmanager;
    // Start is called before the first frame update
    void Start()
    {
      damage = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void on(){
      this.gameObject.SetActive(true);
      switch(movemanager.playerdirection){
        case 0:
          buki_animator.SetInteger("buki_direction",0);
        break;
        case 1:
          buki_animator.SetInteger("buki_direction",1);
        break;
        case 2:
          buki_animator.SetInteger("buki_direction",2);
        break;
        case 3:
          buki_animator.SetInteger("buki_direction",3);
        break;
    }
  }
    public void end(){
      atackmanager.AtackAnimation = false;
      atack_hit = false;
      this.gameObject.SetActive(false);
    }
    
    void OnCollisionEnter2D(Collision2D collision2){//武器が当たったらダメージ
      if(collision2.gameObject.GetComponent<EnemyHpManager>()&&!atack_hit){
        collision2.gameObject.GetComponent<EnemyHpManager>().DamageHP(damage);
        Vector3 enemypos = collision2.gameObject.transform.position;
        efectmanager.efecton(enemypos.x,enemypos.y);//エフェクト作成
        atack_hit = true;
      }
    }
}
