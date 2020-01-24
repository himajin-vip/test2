using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronSword : MonoBehaviour,IItem
{
  private int Id = 1;
  private int Str = 5;
  public void ItemUse(){

  }
  public int ItemSet(){
    return Str;
  }
  public int ItemGet(){
    return Id;
  }
  public void DropItem(){

  }
  public void DropEnd(){

  }
}
