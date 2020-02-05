using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip
{
  public Weapon weapon{get; private set;} = new Weapon();
  public Head head{get; private set;} = new Head();
  public Body body{get; private set;} = new Body();
  public Hand hand{get; private set;} = new Hand();
  public Foot foot{get; private set;} = new Foot();
  public Accessory accessory{get; private set;} = new Accessory();


public void Weapon(int ItemId){
  if(weapon.ItemId != 9999){
    weapon.UnSet(weapon.ItemId);
  }
  weapon.Set(ItemId);
}
public void Head(int ItemId){
  if(head.ItemId != 9999){
    head.UnSet(head.ItemId);
  }
  head.Set(ItemId);
}
public void Body(int ItemId){
  if(body.ItemId != 9999){
    body.UnSet(body.ItemId);
  }
  body.Set(ItemId);
}
public void Hand(int ItemId){
  if(hand.ItemId != 9999){
    hand.UnSet(hand.ItemId);
  }
  hand.Set(ItemId);
}
public void Foot(int ItemId){
  if(foot.ItemId != 9999){
    foot.UnSet(foot.ItemId);
  }
  foot.Set(ItemId);
}
public void Accessory(int ItemId){
  if(accessory.ItemId != 9999){
   accessory.UnSet(accessory.ItemId);
  }
  accessory.Set(ItemId);
}








}
