﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public string Name;
  public int EnemyId;
  public int MaxHp;
  public int CurrentHp;
  public int Mp;
  public int Str;
  public int Def;
  public int Exp;
  public int Gold;
  public int DropItem;
  public int MoveSpeed;
  public int MoveStatus;
  public float AtackWaitTime;
  public bool DeathCheck;
  public bool AtackOn;
  public bool MoveOn;
  public int MoveOnX;
  public int MoveOnY;

  public virtual void Atack(GameObject Playerobj){
  }
  public void DamageHp(int damage){
      CurrentHp -= damage;
      float x = this.transform.position.x;
      float y = this.transform.position.y;
      DamageTextManager.Make(damage,x,y,new Color(255,255,255),this.transform);
      LogManager.MakeDamageLog(Name,damage);
  }
  public void RecoveryHp(int recovery){
    CurrentHp += recovery;
    if(CurrentHp>MaxHp){
      CurrentHp = MaxHp;
    }
    float x = this.transform.position.x;
    float y = this.transform.position.y;
    DamageTextManager.Make(recovery,x,y,new Color(0,255,0),this.transform);
    EfectManager.efecton("kaihukuefect",this.transform.position.x,this.transform.position.y,this.gameObject);
  }
  public void Move(){
    if(MoveStatus == 1&&!DeathCheck){//プレイヤーを追いかける
      Vector3 player_pos = PlayerManager.ReturnPosition();
      Vector3 this_pos = this.transform.position;
      if(player_pos.x>this_pos.x){
      this.transform.Translate(MoveSpeed,0,0);
      }
      if(player_pos.x<this_pos.x){
      this.transform.Translate(-MoveSpeed,0,0);
      }
      if(player_pos.y>this_pos.y){
      this.transform.Translate(0,MoveSpeed,0);
      }
      if(player_pos.y<this_pos.y){
      this.transform.Translate(0,-MoveSpeed,0);
      }
    }
    if(MoveStatus == 0&&!DeathCheck){//自由に動く
      int action = Random.Range(0,20);
      if(action == 1&&!MoveOn){
        MoveOn = true;
        MoveOnX = Random.Range(-1,2);
        MoveOnY = Random.Range(-1,2);
        StartCoroutine(MoveWait(32));
      }
    }
  }
  private IEnumerator MoveWait(int frame){
    float CameraposX = CameraManager.ReturnPosition().x;
    float CameraposY = CameraManager.ReturnPosition().y;
    int CameraSizeX = 640;
    int CameraSizeY = 480;
    while (frame > 0) {
       yield return null;
           if(MoveOn){
         if(MoveOnX == 1){
           if(this.transform.position.x+MoveSpeed<CameraposX+CameraSizeX/2){
             this.transform.Translate(MoveSpeed,0,0);
           }
         }
         if(MoveOnX == -1){
           if(this.transform.position.x+MoveSpeed>CameraposX-CameraSizeX/2){
             this.transform.Translate(-MoveSpeed,0,0);
           }
         }
         if(MoveOnY == 1){
           if(this.transform.position.y+MoveSpeed<CameraposY+CameraSizeY/2){
             this.transform.Translate(0,MoveSpeed,0);
           }
         }
         if(MoveOnY == -1){
           if(this.transform.position.y-MoveSpeed>CameraposY-CameraSizeY/2){
             this.transform.Translate(0,-MoveSpeed,0);
           }
         }
       }
       frame--;
     }
     MoveOn = false;
  }
  public void Death(){
    DeathCheck = true;
    ItemDrop();
    PlayerManager.GetExp(Exp);
    StartCoroutine(DestroyEnemy());
  }
  public void ItemDrop(){
    int i ;
    i = Random.Range(0,3);
    if(i == 2){
      ItemManager.DropItemMake(DropItem,this.transform.position.x,this.transform.position.y);
    }
  }

  void OnCollisionStay2D(Collision2D collision2){
    if(!DeathCheck){
      if(collision2.gameObject.GetComponent<Player>()&&!AtackOn){
        AtackOn = true;
        StartCoroutine(AtackWait());
        Atack(collision2.gameObject);
      }
    }
  }
  private IEnumerator AtackWait(){
    yield return new WaitForSeconds(AtackWaitTime);
    AtackOn = false;
  }
  private IEnumerator DestroyEnemy(){
    yield return new WaitForSeconds(0.5f);
    Destroy(this.gameObject);//hpが０になったら死ぬ
  }

  public void DestroyMapMove(){
    Debug.Log("Destroy");
    Destroy(this.gameObject);
  }
}
