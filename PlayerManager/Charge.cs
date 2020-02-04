using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
  public Coroutine ChargeC;
  public Efect Efect;
  public bool ChargeNow = false;
  public void Set(){
    ChargeC = StartCoroutine(ChargeStart());
  }
  public void Stop(){
    StopCoroutine(ChargeC);
    AudioManager.AudioOFF(4);
    if(ChargeNow){
      GameObject.Destroy(Efect.gameObject);
    }
    ChargeNow = false;
  }

  public  IEnumerator ChargeStart(){
    yield return new WaitForSeconds(PlayerManager.Player.ChargeTime/2);
      ChargeNow = true;
      Efect = EfectManager.efecton("tameefect",PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,PlayerManager.Player.GameObject);
      AudioManager.AudioON(4);
      PlayerManager.Player.MoveSpeed.SetChargeSpeed();

    yield return new WaitForSeconds(PlayerManager.Player.ChargeTime/2);
      Efect.GetComponent<Animator>().SetFloat("Speed", 2.0f);
      PlayerManager.Player.SetChargeSkill();
  }

}
