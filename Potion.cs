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
      Debug.Log(recovery);
      obj.gameObject.GetComponent<Player_HP_Manager>().recoveryHP(recovery);
    }
    public void ItemSet(){
    }
    public int ItemGet(){
      return Id;
    }
}
