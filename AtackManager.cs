using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackManager : MonoBehaviour
{
  public bool AtackAnimation = false;
  public MoveManager movemanager;
  public bukimanager bukimanager;
  public EfectManager efectmanager;
  GameObject ChargeEfect;
  int ChargeAtackCount = 0;
  int chargetime = 120;
  public bool atackon = false;
  public bool ChargeEfectOn = false;
  public bool fullcharge = false;
  void Start(){
  }
  void Update(){
    if(Input.GetKeyDown(KeyCode.Space) && !atackon){
      atackon = true;
      }
    if(Input.GetKeyUp(KeyCode.Space)&&atackon){
      AtackAnimation = true;
      ChargeAtackCount = 0;
      if(ChargeEfectOn){
        ChargeEfect.GetComponent<efectend>().end();
        movemanager.SpeedSet(3);
        ChargeEfectOn = false;
      }
      bukimanager.on();
    }
    if(atackon){
      ChargeAtackCount++;
      if(ChargeAtackCount>(chargetime/3)&&!ChargeEfectOn){
        ChargeEfect = efectmanager.efecton(movemanager.playerpos.x,movemanager.playerpos.y,this.gameObject);
        movemanager.SpeedSet(1);
        ChargeEfectOn = true;
      }
      if(ChargeAtackCount>chargetime){
        ChargeEfect.GetComponent<Animator>().SetFloat("Speed", 2.0f);
        fullcharge = true;
        bukimanager.ChargeDamageSet();
      }
    }
  }
}
