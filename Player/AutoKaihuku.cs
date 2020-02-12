using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoKaihuku : MonoBehaviour
{
  private float kaihukuTime = 5f;
  private Coroutine kaihukuC;
  private Player player;
  public void SetUp(){
    kaihukuC = StartCoroutine(kaihukuStart());
    player = transform.parent.GetComponent<Player>();
  }

  public void Set(){
    kaihukuC = StartCoroutine(kaihukuStart());
  }

  public  IEnumerator kaihukuStart(){
    yield return new WaitForSeconds(kaihukuTime);
        player.Status.Hp.Recovery(10*player.Status.Lv);
        player.Status.Mp.Recovery(1*player.Status.Lv);
        Set();
  }

}
