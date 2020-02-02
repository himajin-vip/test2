using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MapManager
{
  private static Dictionary<int,Map> MapList = new Dictionary<int,Map>();
  private static Map Map;
  private static int LastMap;

  public static void SetUp(){
    MapList.Clear();

    MapList.Add(0,new TestMap1());
    MapList.Add(1,new SougenMap());
    MapList[1].SetUp();

    Map = MapList[0];
    LastMap = 0;
    Map.Start(LastMap);

  }

  public static void MapChange(int NextMapNo){
    Map.End();
    Map = MapList[NextMapNo];
    Map.Start(LastMap);
    LastMap = NextMapNo;
  }

  public static void MapEvent(int EventNo){
    Map.Event(EventNo);
  }

  public static int ReturnLastMap(){
    return LastMap;
  }
  public static void MapMove(int Direction){
    Map.MapMove(Direction);
  }

  public static MapEnemyList ReturnEnemyList(){
    return Map.ReturnEnemyList();
  }

}
