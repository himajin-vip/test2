using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackManager : MonoBehaviour
{
  public bool AtackAnimation = false;
  public MoveManager movemanager;
  public bukimanager bukimanager;
  void Start(){
  }
  void Update(){
    if(Input.GetKeyDown(KeyCode.Space) && !AtackAnimation){
      bukimanager.on();
      AtackAnimation = true;
      }
  }
}
