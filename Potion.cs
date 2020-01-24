using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour,IItem
{
  private int Id = 0;
  private int recovery = 30;
  //private string Itemname = ("ポーション");

    public void ItemUse(){
      PlayerManager.Player.GetComponent<Player>().RecoveryHp(recovery);
    }
    public int ItemSet(){
      return 0;
    }
    public int ItemGet(){
      return Id;
    }
    public void DropItem(){
      int rndx = Random.Range(-18000, 18000);
      int rndy =  Random.Range(-18000, 18000);
      GetComponent<Rigidbody2D>().AddForce(new Vector2(rndx,rndy));
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
