using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efect
{
  EfectObj efect;
  Animator Animator;

    public void On(string efectname ,GameObject parent){
      GameObject obj = (GameObject)Resources.Load ("prefab/Efect/"+efectname);
      GameObject obj2 = GameManager.Instantiate(obj, new Vector3(parent.transform.position.x,parent.transform.position.y,0), Quaternion.identity);
      obj2.transform.parent = parent.transform;
      efect = obj2.GetComponent<EfectObj>();
      Animator = obj2.GetComponent<Animator>();
    }
    public void Off(){
      efect.OnEnd();
    }
    public void SetSpeed(float speed){
      Animator.SetFloat("Speed", speed);
    }
}
