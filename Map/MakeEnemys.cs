using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MakeEnemys
{
    public List<Enemys> enemys(params Enemys[] enemytypes){
        List<Enemys> enemys = new List<Enemys>();
        foreach(Enemys enemy in enemytypes){
            enemys.Add(enemy);
        }
        return enemys;
    }
    public List<Value> Values(params int[] values){
         List<Value> Values = new List<Value>();
        foreach(int i in values){
            Values.Add(new IntValue(i));
        }
        return Values;
    }

}