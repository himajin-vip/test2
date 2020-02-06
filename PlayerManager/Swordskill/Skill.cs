using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Skill{

  void Damage(Dictionary<int,Enemy> EnemyList);
  void AtackOn();

  int returnMp();

}
