using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEnemys
{
    private Dictionary<Enemys,Value> Enemys = new Dictionary<Enemys, Value>();
    public MapEnemys(List<Enemys> enemys , List<Value> values){
      for(int i = 0;i<enemys.Count ;i++){
        Enemys.Add(enemys[i],values[i]);
      }
    }
    public Dictionary<Enemys,Value> GetEnemys(){
      return new Dictionary<Enemys, Value>(Enemys);
    }
}
