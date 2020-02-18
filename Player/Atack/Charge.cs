using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
  private Playerp Playerp;
  private GameObject PlayerpObj;
  private float ChargeTime = 2f;
  private Coroutine ChargeC;
  private Efect Efect = new Efect();
  private bool ChargeNow = false;

  public void SetUp(Playerp Playerp ,GameObject Playerpobj){
    // Playerp = Playerp;
    PlayerpObj = Playerpobj;
  }
  public void Set(){
    ChargeC = StartCoroutine(ChargeStart());
  }
  public void Stop(){
    StopCoroutine(ChargeC);
    new StopAudio().Stop(AudioList.Charge);
    if(ChargeNow){
      Efect.Off();
    }
    ChargeNow = false;
  }

  public  IEnumerator ChargeStart(){
    yield return new WaitForSeconds(ChargeTime/2);
      ChargeNow = true;
      Efect.On("tameefect",PlayerpObj);
      new PlayAudio().Play(AudioList.Charge);
      Playerp.MoveSpeed.SetChargeSpeed();

    yield return new WaitForSeconds(ChargeTime/2);
      Efect.SetSpeed(2.0f);
      Playerp.SetChargeSkill();
  }

}
