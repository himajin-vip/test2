using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoKaihuku : MonoBehaviour
{
  private float kaihukuTime = 5f;
  private Coroutine kaihukuC;
  private Efect Efect;
  private bool ChargeNow = false;
  public void Set(){
    kaihukuC = StartCoroutine(kaihukuStart());
  }
  public void Stop(){
    StopCoroutine(kaihukuC);
    AudioManager.AudioOFF(4);
    if(ChargeNow){
      GameObject.Destroy(Efect.gameObject);
    }
    ChargeNow = false;
  }

  public  IEnumerator kaihukuStart(){
    yield return new WaitForSeconds(kaihukuTime);
        PlayerManager.Player.Hp.Recovery(10);
        PlayerManager.Player.Mp.Recovery(1);
        Set();
  }

}
