using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public int EnemyId;
  public List<DropItemData> DropItemList = new List<DropItemData>();
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
  
  public GameObject PlayerpObj;
  public Playerp Playerp;

  public void SetUp(){
    Direction = new Direction(this.GetComponent<Animator>());
    // move = new Move(this.gameObject,Direction);
  }
  public virtual void Atack(GameObject Playerpobj){
    // DamageCheck DamageCheck = new DamageCheck();
    // DamageCheck.Playerp(PlayerpObj,Name,Lv,Str.Value);
    // Vector3 Playerppos = Playerpobj.gameObject.transform.position;
    // Efect Efect = new Efect();
    // Efect.On("Kamitukiefect",Playerpobj);//エフェクト作成
    // new PlayAudio().Play(AudioList.Kamituki);
  }

  public void Move(){
    // if(MoveStatus == 1&&!DeathCheck){//プレイヤーを追いかける
    //   Vector3 Playerp_pos = PlayerpObj.transform.position;
    //   Vector3 this_pos = this.transform.position;
    //   if(Playerp_pos.x>this_pos.x){
    //     move.Right(MoveSpeed);
    //   }
    //   if(Playerp_pos.x<this_pos.x){
    //     move.Left(MoveSpeed);
    //   }
    //   if(Playerp_pos.y>this_pos.y){
    //     move.Up(MoveSpeed);
    //   }
    //   if(Playerp_pos.y<this_pos.y){
    //     move.Down(MoveSpeed);
    //   }
    // }
    // if(MoveStatus == 0&&!DeathCheck){//自由に動く
    //   int action = Random.Range(0,20);
    //   if(action == 1&&!MoveOn){
    //     MoveOn = true;
    //     MoveOnX = Random.Range(-1,2);
    //     MoveOnY = Random.Range(-1,2);
    //     StartCoroutine(MoveWait(32));
    //   }
    // }
  }
  // private IEnumerator MoveWait(int frame){
  //   // float CameraposX = Camera.main.gameObject.transform.position.x;
  //   // float CameraposY = Camera.main.gameObject.transform.position.y;
  //   // int CameraSizeX = 640;
  //   // int CameraSizeY = 480;
  //   // while (frame > 0) {
  //   //    yield return null;
  //   //        if(MoveOn){
  //   //      if(MoveOnX == 1){
  //   //        if(this.transform.position.x+MoveSpeed<CameraposX+CameraSizeX/2){
  //   //          move.Right(MoveSpeed);
  //   //        }
  //   //      }
  //   //      if(MoveOnX == -1){
  //   //        if(this.transform.position.x+MoveSpeed>CameraposX-CameraSizeX/2){
  //   //          move.Left(MoveSpeed);
  //   //        }
  //   //      }
  //   //      if(MoveOnY == 1){
  //   //        if(this.transform.position.y+MoveSpeed<CameraposY+CameraSizeY/2){
  //   //          move.Up(MoveSpeed);
  //   //        }
  //   //      }
  //   //      if(MoveOnY == -1){
  //   //        if(this.transform.position.y-MoveSpeed>CameraposY-CameraSizeY/2){
  //   //          move.Down(MoveSpeed);
  //   //        }
  //   //      }
  //   //    }
  //   //    frame--;
  //   //  }
  //   //  MoveOn = false;
  // }
  void OnCollisionStay2D(Collision2D collision2){
    if(!DeathCheck){
      if(collision2.gameObject.GetComponent<Playerp>()&&!AtackOn){
        PlayerpObj = collision2.gameObject;
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
