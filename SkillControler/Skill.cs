using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Skill{

  void On(PlayerObjectManager player,List<Enemy> hitList);
  void DamageCheck(Player player,List<Enemy> list);

  // int returnMp();

}
