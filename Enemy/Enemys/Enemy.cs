using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Charactor
{
  bool FindMove = false;
  public Enemy(){
    DataCounter.AddCounters(new StatusCounter());
  }
}
