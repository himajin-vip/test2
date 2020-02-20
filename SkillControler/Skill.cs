using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Skill{

  void On(PlayerObjectManager player);
  void DamageCheck(Player player,List<Enemy> list);

  // int returnMp();

}
