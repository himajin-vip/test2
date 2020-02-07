using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public int EnemyId;
  public Name Name{get; protected set;}
  public Lv Lv{get; protected set;}
  public Hp Hp{get; protected set;}
  public Mp Mp{get; protected set;}
  public Str Str{get; protected set;}
  public Vit Vit{get; protected set;}
  public Dex Dex{get; protected set;}
  public Int Int{get; protected set;}
  public int Exp;
  public int Gold;
  public List<DropItem> DropItemList = new List<DropItem>();
  public int MoveSpeed;
  public int MoveStatus;
  public float AtackWaitTime;
  public bool DeathCheck;
  public bool AtackOn;
  public bool MoveOn;
  public int MoveOnX;
  public int MoveOnY;

  public virtual void Atack(GameObject Playerobj){

    Damage Damage = new Damage();
    int FinalDamage = Damage.Check(Lv.Value,Str.Value,PlayerManager.Player.Lv.Value,PlayerManager.Player.Vit.Value);
    FiledTextManager.Make(FinalDamage.ToString(),Playerobj.transform.position.x,Playerobj.transform.position.y,new Color(255,0,0),Playerobj.transform);
    LogManager.MakeDamageLog(PlayerManager.Player.Name.Value,FinalDamage);
    PlayerManager.Player.Hp.Damage(FinalDamage);
    Vector3 Playerpos = Playerobj.gameObject.transform.position;
    EfectManager.efecton("Kamitukiefect",Playerpos.x,Playerpos.y,Playerobj);//エフェクト作成
    AudioManager.AudioON(8);
  }

  public void Move(){
    if(MoveStatus == 1&&!DeathCheck){//プレイヤーを追いかける
      Vector3 player_pos = PlayerManager.Player.GameObject.transform.position;
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
    new ItemDrop(DropItemList,this.transform);
    int exp = Exp;
    if(Lv.Value<PlayerManager.Player.Lv.Value){
      double down = ((PlayerManager.Player.Lv.Value - Lv.Value)/10f);
                 exp =(int)(Exp * (1f-down));
    }
          PlayerManager.Player.Exp.Get(exp);
    StartCoroutine(DestroyEnemy());
  }

  void OnCollisionStay2D(Collision2D collision2){
    if(!DeathCheck){
      if(collision2.gameObject.GetComponent<PlayerObj>()&&!AtackOn){
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
