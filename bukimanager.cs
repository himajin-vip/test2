using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bukimanager : MonoBehaviour
{
  public int damage ;
  public Animator buki_animator;
  public AtackManager atackmanager;
  public MoveManager movemanager;
  public bool atack_hit;
    // Start is called before the first frame update
    void Start()
    {
      damage = 3;
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
      atackmanager.AtackAnimation = false;
      atack_hit = false;
      this.gameObject.SetActive(false);
    }
    public int Return_damage(){
      Debug.Log(damage);
      atack_hit=true;
      return this.damage;
    }
}
