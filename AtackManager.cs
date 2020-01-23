using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackManager : MonoBehaviour
{
  public MoveManager movemanager;
  public bukimanager bukimanager;
  public EfectManager efectmanager;
  GameObject ChargeEfect;
  Coroutine ChargeC ;
  public bool AtackAnimation = false;
  public bool atackon = false;
  public bool ChargeEfectOn = false;
  public bool fullcharge = false;
  public bool keyup = false;

  void Start(){
  }
  void Update(){
  }
  public void AtackKeyDown(){
    if(!atackon){//攻撃キーを押したか判定
      atackon = true;
      ChargeC = StartCoroutine(ChargeAtack());
    }
  }
  public void AtackKeyUp(){
    if(atackon){//攻撃キーを離したか判定
      AtackAnimation = true;
      if(ChargeEfectOn){
        ChargeEfect.GetComponent<efectend>().end();
        movemanager.SpeedSet(3);
        ChargeEfectOn = false;
      }
      bukimanager.on();
      StopCoroutine(ChargeC);
    }
  }
  private IEnumerator ChargeAtack(){
    yield return new WaitForSeconds(1f);
      ChargeEfect = efectmanager.efecton(movemanager.playerpos.x,movemanager.playerpos.y,this.gameObject);
      movemanager.SpeedSet(1);
      ChargeEfectOn = true;
    yield return new WaitForSeconds(1f);
      ChargeEfect.GetComponent<Animator>().SetFloat("Speed", 2.0f);
      fullcharge = true;
      bukimanager.ChargeDamageSet();
  }
}
