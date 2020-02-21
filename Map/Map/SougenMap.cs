using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SougenMap : MapData
{
  private List<MapEnemys> MapEnemyList = new List<MapEnemys>();
  private Value MapNo = new IntValue(0);
  public SougenMap(){
    MapEnemyList.Add(new MapEnemys(new MakeEnemys().enemys(Enemys.RedSlime),new MakeEnemys().Values(0)));
    MapEnemyList.Add(new MapEnemys(new MakeEnemys().enemys(Enemys.Slime),new MakeEnemys().Values(1)));
    MapEnemyList.Add(new MapEnemys(new MakeEnemys().enemys(Enemys.Slime),new MakeEnemys().Values(3)));
    MapEnemyList.Add(new MapEnemys(new MakeEnemys().enemys(Enemys.Slime,Enemys.RedSlime),new MakeEnemys().Values(2,3)));
  }
  public Dictionary<Enemys,Value> GetEnemys(){
    return MapEnemyList[MapNo.GetIntValue()].GetEnemys();
  }
  public void MapMove(StateData state){
    int i = state.cameraMoveValue.GetIntValue();
    switch(i){
      case 2:
        MapNo.Add(new IntValue(1));
      break;
      case 3:
        MapNo.Add(new IntValue(-1));
      break;
    }
    
  }
}
