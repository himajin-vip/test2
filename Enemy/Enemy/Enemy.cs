using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public int EnemyId;
  public string Name{get; protected set;}
  public int Lv{get; protected set;}
  public StatusHp Hp{get; protected set;}
  public StatusMp Mp{get; protected set;}
  public StatusBattle Str{get; protected set;}
  public StatusBattle Vit{get; protected set;}
  public StatusBattle Dex{get; protected set;}
  public StatusBattle Int{get; protected set;}
  public int Exp;
  public int Gold;
  public List<DropItem> DropItemList = new List<DropItem>();
  public Move move;
  public Direction Direction;
  public int MoveSpeed;
  public int MoveStatus;
  public float AtackWaitTime;
  public bool DeathCheck;
  public bool AtackOn;
  public bool MoveOn;
  public int MoveOnX;
  public int MoveOnY;
  
  public GameObject PlayerObj;
  public Player player;

  public void SetUp(){
    Direction = new Direction(this.GetComponent<Animator>());
    move = new Move(this.gameObject,Direction);
  }
  public virtual void Atack(GameObject Playerobj){
    DamageCheck DamageCheck = new DamageCheck();
    DamageCheck.Player(PlayerObj,Name,Lv,Str.Value);
    Vector3 Playerpos = Playerobj.gameObject.transform.position;
    Efect Efect = new Efect();
    Efect.On("Kamitukiefect",Playerobj);//エフェクト作成
    AudioManager.AudioON(8);
  }

  public void Move(){
    if(MoveStatus == 1&&!DeathCheck){//プレイヤーを追いかける
      Vector3 player_pos = PlayerObj.transform.position;
      Vector3 this_pos = this.transform.position;
      if(player_pos.x>this_pos.x){
        move.Right(MoveSpeed);
      }
      if(player_pos.x<this_pos.x){
        move.Left(MoveSpeed);
      }
      if(player_pos.y>this_pos.y){
        move.Up(MoveSpeed);
      }
      if(player_pos.y<this_pos.y){
        move.Down(MoveSpeed);
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
    float CameraposX = Camera.main.gameObject.transform.position.x;
    float CameraposY = Camera.main.gameObject.transform.position.y;
    int CameraSizeX = 640;
    int CameraSizeY = 480;
    while (frame > 0) {
       yield return null;
           if(MoveOn){
         if(MoveOnX == 1){
           if(this.transform.position.x+MoveSpeed<CameraposX+CameraSizeX/2){
             move.Right(MoveSpeed);
           }
         }
         if(MoveOnX == -1){
           if(this.transform.position.x+MoveSpeed>CameraposX-CameraSizeX/2){
             move.Left(MoveSpeed);
           }
         }
         if(MoveOnY == 1){
           if(this.transform.position.y+MoveSpeed<CameraposY+CameraSizeY/2){
             move.Up(MoveSpeed);
           }
         }
         if(MoveOnY == -1){
           if(this.transform.position.y-MoveSpeed>CameraposY-CameraSizeY/2){
             move.Down(MoveSpeed);
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
    if(Lv<player.Status.Lv){
      double down = ((player.Status.Lv - Lv)/10f);
      exp =(int)(Exp * (1f-down));
    }
    player.GetExp(exp);
    new AddGold().Add(new Gold(Gold));
    StartCoroutine(DestroyEnemy());
  }

  void OnCollisionStay2D(Collision2D collision2){
    if(!DeathCheck){
      if(collision2.gameObject.GetComponent<Player>()&&!AtackOn){
        PlayerObj = collision2.gameObject;
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
