using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

  public EfectManager efectmanager;
  public Enemyatack enemyatack;
  public EnemyHpManager enemyhpmanager;
  public bool atackon = false;
  bool move_on = false;
  int enemypower = 5;
  int move_count = 0;
  int status = 0; //0:待機（自動移動）1:発見（キャラ追尾）
  int move_x_on;
  int move_y_on;
  int action = 0;
  int move_speed = 1;
  Vector3  enemyvector3;
    // Start is called before the first frame update
    void Start(){
      enemyvector3 = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update(){
      if(!enemyhpmanager.Deth){
        if(status == 1){//プレイヤーを追いかける
          Vector3 player_pos = GameObject.Find("Player").transform.position;
          Vector3 this_pos = this.transform.position;
          if(player_pos.x>this_pos.x){
            this.transform.Translate(move_speed,0,0);
          }
          if(player_pos.x<this_pos.x){
            this.transform.Translate(-move_speed,0,0);
          }
          if(player_pos.y>this_pos.y){
            this.transform.Translate(0,move_speed,0);
          }
          if(player_pos.y<this_pos.y){
            this.transform.Translate(0,-move_speed,0);
          }
          enemyvector3 = this.gameObject.transform.position;
        }
        if(status == 0){//自由に動く
          action = Random.Range(0,10);
          if(action == 1&&!move_on){
            move_x_on = Random.Range(-1,2);
            move_y_on = Random.Range(-1,2);
            move_on = true;
          }
          if(move_on){
            if(move_x_on == 1){
              this.transform.Translate(move_speed,0,0);
            }
            if(move_x_on == -1){
              this.transform.Translate(-move_speed,0,0);
            }
            if(move_y_on == 1){
              this.transform.Translate(0,move_speed,0);
            }
            if(move_y_on == -1){
              this.transform.Translate(0,-move_speed,0);
            }
            move_count++;
            enemyvector3 = this.gameObject.transform.position;
          }
          if(move_count>=32){
            move_count = 0;
            move_on = false;
          }
        }
      }
    }

    private IEnumerator atacktime(){
      yield return new WaitForSeconds(1f);
      atackon = false;
    }

    void OnTriggerEnter2D(Collider2D collision){//プレイヤーを発見したらstatusを変更
      if(!enemyhpmanager.Deth){
        if(collision.gameObject.GetComponent<MoveManager>()){
          status = 1;
        }
      }
    }

    void OnCollisionStay2D(Collision2D collision2){
      if(!enemyhpmanager.Deth){
        if(collision2.gameObject.GetComponent<MoveManager>()&&!atackon){
          atackon = true;
          StartCoroutine(atacktime());
          enemyatack.atack(enemypower,collision2.gameObject.GetComponent<MoveManager>().playerpos.x,collision2.gameObject.GetComponent<MoveManager>().playerpos.y,collision2.gameObject.GetComponent<Player_HP_Manager>());
        }
      }
    }
}
