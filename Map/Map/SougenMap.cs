using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SougenMap : MapData
{
  private List<MapEnemys> MapEnemyList = new List<MapEnemys>();
  private Value MapNo = new IntValue(0);
  public SougenMap(){
    MapEnemyList.Add(new MapEnemys(new MakeEnemys().enemys(Enemys.slime),new MakeEnemys().Values(1)));
    MapEnemyList.Add(new MapEnemys(new MakeEnemys().enemys(Enemys.Redslime),new MakeEnemys().Values(1)));
  }
  public Dictionary<Enemys,Value> GetEnemys(){
    return MapEnemyList[MapNo.GetIntValue()].GetEnemys();
  }
  public void MapMove(Value value){
    MapNo.Add(value);
  }
}
