using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface MapData
{
  Dictionary<Enemys,Value> GetEnemys();
  void MapMove(StateData stateData);
  
}
