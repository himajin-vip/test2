using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equip
{
  public Weapon Weapon{get; private set;} = new Weapon();
  public Head Head{get; private set;} = new Head();
  public Body Body{get; private set;} = new Body();
  public Hand Hand{get; private set;} = new Hand();
  public Foot Foot{get; private set;} = new Foot();
  public Accessory Accessory{get; private set;} = new Accessory();

  public int Str {get; private set;}
  public int Vit {get; private set;}
  public int Dex {get; private set;}
  public int Int {get; private set;}

  public void SetStr(int str){
    Str+=str;
  }
  public void SetVit(int vit){
    Vit+=vit;
  }
  public void SetDex(int dex){
    Dex+=dex;
  }
  public void SetInt(int iint){
    Int+=iint;
  }

}
