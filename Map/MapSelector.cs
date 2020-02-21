using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelector
{
    Dictionary<Maps,MapData> MapDatas = new Dictionary<Maps, MapData>();
    MapData NowMapData;
    public MapSelector(){
        MapDatas.Add(Maps.Sougen,new SougenMap());
        NowMapData = MapDatas[Maps.Sougen];
    }
    public Dictionary<Enemys,Value> GetEnemys(){
        return NowMapData.GetEnemys();
    }
    public void MapMove(StateData stateData){
        NowMapData.MapMove(stateData);
    }
    public void SetMapData(Maps Nextmap){
        NowMapData = MapDatas[Nextmap];
    }
}