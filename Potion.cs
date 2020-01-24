using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour,IItem
{
  public int Id = 0;
  public int recovery = 30;
  public string Itemname = ("ポーション");
  void Start(){
    Id = 0;
    recovery = 10;
    Itemname = ("ポーション");
  }

    public void ItemUse(GameObject obj){
      obj.gameObject.GetComponent<Player_HP_Manager>().recoveryHP(recovery);
    }
    public void ItemSet(){
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
      Debug.Log("stop");
      GetComponent<Rigidbody2D>().velocity = Vector3.zero;
      GetComponent<Rigidbody2D>().isKinematic = true;
    }
}
