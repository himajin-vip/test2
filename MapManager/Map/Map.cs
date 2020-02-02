using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Map
{
  void SetUp();
  void Start(int LastMap);
  void Event(int EventNo);
  void MapMove(int Direction);
  MapEnemyList ReturnEnemyList();
  void End();
}
