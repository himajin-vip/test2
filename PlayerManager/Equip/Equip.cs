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

}
