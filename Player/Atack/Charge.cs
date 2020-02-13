using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charge : MonoBehaviour
{
  private Player Player;
  private GameObject PlayerObj;
  private float ChargeTime = 2f;
  private Coroutine ChargeC;
  private Efect Efect = new Efect();
  private bool ChargeNow = false;

  public void SetUp(Player player ,GameObject playerobj){
    Player = player;
    PlayerObj = playerobj;
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
      Efect.On("tameefect",PlayerObj);
      new PlayAudio().Play(AudioList.Charge);
      Player.MoveSpeed.SetChargeSpeed();

    yield return new WaitForSeconds(ChargeTime/2);
      Efect.SetSpeed(2.0f);
      Player.SetChargeSkill();
  }

}
