using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
  private float ChargeTime = 2f;
  private Coroutine ChargeC;
  private Efect Efect = new Efect();
  private bool ChargeNow = false;
  public void Set(){
    ChargeC = StartCoroutine(ChargeStart());
  }
  public void Stop(){
    StopCoroutine(ChargeC);
    AudioManager.AudioOFF(4);
    if(ChargeNow){
      Efect.Off();
    }
    ChargeNow = false;
  }

  public  IEnumerator ChargeStart(){
    yield return new WaitForSeconds(ChargeTime/2);
      ChargeNow = true;
      Efect.On("tameefect",GameManager.Player.GameObject);
      AudioManager.AudioON(4);
      GameManager.Player.MoveSpeed.SetChargeSpeed();

    yield return new WaitForSeconds(ChargeTime/2);
      Efect.SetSpeed(2.0f);
      GameManager.Player.SetChargeSkill();
  }

}
