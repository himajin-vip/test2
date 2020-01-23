using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bukimanager : MonoBehaviour
{
  int Damage = 3 ;
  int NomalDamage = 3;
  int ChargeDamage = 12 ;
  public Animator buki_animator;
  public AtackManager atackmanager;
  public MoveManager movemanager;
  public bool atack_hit = false;
  public EfectManager efectmanager;
    // Start is called before the first frame update
    void Start()
    {

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
      atackmanager.atackon = false;
      atackmanager.AtackAnimation = false;
      atack_hit = false;
      this.gameObject.SetActive(false);
      if(atackmanager.fullcharge){
        Damage = NomalDamage;
        atackmanager.fullcharge = false;
      }
    }
    public void ChargeDamageSet(){
      Damage = ChargeDamage;
    }

    void OnCollisionEnter2D(Collision2D collision2){//武器が当たったらダメージ
      if(collision2.gameObject.GetComponent<EnemyHpManager>()&&!atack_hit){
        collision2.gameObject.GetComponent<EnemyHpManager>().DamageHP(Damage);
        Vector3 enemypos = collision2.gameObject.transform.position;
        efectmanager.kiriefecton(enemypos.x,enemypos.y,collision2.gameObject);//エフェクト作成
        if(!atackmanager.fullcharge){
          atack_hit = true;
        }
      }
    }
}
