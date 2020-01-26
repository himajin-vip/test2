using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
  public int ItemId;

  public void SetUp(int itemid,float x,float y){
    int rndx = Random.Range(-18000, 18000);
    int rndy =  Random.Range(-18000, 18000);
    GetComponent<Rigidbody2D>().AddForce(new Vector2(rndx,rndy));
    ItemId = itemid;
    StartCoroutine(StopItem());
  }
  public void DropEnd(){
    Destroy(this.gameObject);
  }
  private IEnumerator StopItem(){
    yield return new WaitForSeconds(1f);
    GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    GetComponent<Rigidbody2D>().isKinematic = true;
  }
}
