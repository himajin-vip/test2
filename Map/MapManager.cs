using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager
{
  MapSelector MapSelector = new MapSelector();
  Dictionary<Maps,GameObject> MapObjects = new Dictionary<Maps, GameObject>();

  public void Load(){
  }
  public Dictionary<Enemys,Value> GetEnemys(){
    return MapSelector.GetEnemys();
  }
  public void SetMapData(Maps nextmap){
    MapSelector.SetMapData(nextmap);
    SetMapObject(nextmap);
  }
  private void SetMapObject(Maps nextmap){
    // GameObject.Instantiate(MapObjects[nextmap],new Vector3(0,0,0),Quaternion.identity);
  }
  public void MapMove(StateData statedata){
    MapSelector.MapMove(statedata);
  }

}
