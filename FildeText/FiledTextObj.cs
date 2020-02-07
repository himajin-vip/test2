using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiledText : MonoBehaviour {

  public void go(){
    int randx = Random.Range(-18000, 18000);
    int randy = Random.Range(-18000, 18000);
    GetComponent<Rigidbody2D>().AddForce(new Vector2(randx,randy));
    StartCoroutine(DestroyObject());
  }

  private IEnumerator DestroyObject(){
      yield return new WaitForSeconds(0.6f);
      Destroy(this.gameObject);
  }
}
