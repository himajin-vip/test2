using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoKaihuku : MonoBehaviour
{
  private float kaihukuTime = 5f;
  private Coroutine kaihukuC;
  private Playerp Playerp;
  public void SetUp(){
    kaihukuC = StartCoroutine(kaihukuStart());
    Playerp = transform.parent.GetComponent<Playerp>();
  }

  public void Set(){
    kaihukuC = StartCoroutine(kaihukuStart());
  }

  public  IEnumerator kaihukuStart(){
    yield return new WaitForSeconds(kaihukuTime);
        Playerp.Status.Hp.Recovery(10*Playerp.Status.Lv);
        Playerp.Status.Mp.Recovery(1*Playerp.Status.Lv);
        Set();
  }

}
