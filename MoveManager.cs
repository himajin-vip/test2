using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
  public Animator player_animator;
  public AtackManager atackmanager;
  public GameObject MenuCanvas;
  public int playerposx;
  public int playerposy;
  public Vector3 playerpos;
  public int move_speed = 3;
  public int playerdirection = 0 ; // 0:前　1:後　2:右　3:左
    // Start is called before the first frame update
    void Start()
    {
      playerpos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      playerpos = this.gameObject.transform.position;

    }
    public void FrontMove(){
      this.transform.Translate (0,-move_speed,0);
      FrontDirection();
    }
    public void BackMove(){
      this.transform.Translate (0,move_speed,0);
      BackDirection();
    }
    public void RightMove(){
      this.transform.Translate (move_speed,0,0);
      RightDirection();
    }
    public void LeftMove(){
      this.transform.Translate (-move_speed,0,0);
      LeftDirection();
    }
    public void FrontDirection(){
      player_animator.SetInteger("move_direction", 0);
      playerdirection = 0;
    }
    public void BackDirection(){
      player_animator.SetInteger("move_direction", 1);
      playerdirection = 1;
    }
    public void RightDirection(){
      player_animator.SetInteger("move_direction", 2);
      playerdirection = 2;
    }
    public void LeftDirection(){
      player_animator.SetInteger("move_direction", 3);
      playerdirection = 3;
    }
    public void SpeedSet(int speed){
      move_speed = speed ;
    }

}
