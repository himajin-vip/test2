using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoKaihuku : MonoBehaviour
{
  private float kaihukuTime = 5f;
  private Coroutine kaihukuC;
  public void Set(){
    kaihukuC = StartCoroutine(kaihukuStart());
  }

  public  IEnumerator kaihukuStart(){
    yield return new WaitForSeconds(kaihukuTime);
        GameManager.Player.Hp.Recovery(10);
        GameManager.Player.Mp.Recovery(1);
        Set();
  }

}
