using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
  public int playerposx;
  public int playerposy;
  public Vector3 playervector3;
  public int move_speed = 3;
  public Animator player_animator;
  public AtackManager atackmanager;
  public int playerdirection = 0 ; // 0:前　1:後　2:右　3:左
    // Start is called before the first frame update
    void Start()
    {
      playervector3 = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      if(!atackmanager.AtackAnimation){
        // 後ろに移動
        if(Input.GetKey(KeyCode.W)){
          //Debug.Log("W");
          if (!Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.W) && !Input.GetKey (KeyCode.D) && !Input.GetKey(KeyCode.A)) {
            player_animator.SetInteger("move_direction", 1);
            playerdirection = 1;
          }
          this.transform.Translate (0,move_speed,0);
        }
        // 左に移動
        if(Input.GetKey(KeyCode.A)){
          if (!Input.GetKey (KeyCode.S) && !Input.GetKey (KeyCode.W) && !Input.GetKey (KeyCode.D) && Input.GetKey(KeyCode.A)) {
              player_animator.SetInteger("move_direction", 3);
              playerdirection = 3;
          }
          this.transform.Translate (-move_speed,0,0);
        }
          // 右に移動
        if(Input.GetKey(KeyCode.D)){
          if (!Input.GetKey (KeyCode.S) && !Input.GetKey (KeyCode.W) && Input.GetKey (KeyCode.D) && !Input.GetKey(KeyCode.A)) {
            player_animator.SetInteger("move_direction", 2);
            playerdirection = 2;
          }
          this.transform.Translate (move_speed,0,0);
        }
        // 前に移動
        if(Input.GetKey(KeyCode.S)){
          if (Input.GetKey (KeyCode.S) && !Input.GetKey (KeyCode.W) && !Input.GetKey (KeyCode.D) && !Input.GetKey(KeyCode.A)) {
            player_animator.SetInteger("move_direction", 0);
            playerdirection = 0;
          }
          this.transform.Translate (0,-move_speed,0);
        }
        playervector3 = this.gameObject.transform.position;
      }

    }

}
