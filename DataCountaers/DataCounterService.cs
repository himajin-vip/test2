using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DataCounterService
{
    List<DataCounter> DataCounters = new List<DataCounter>();
    public void AddCounters(DataCounter newcounter){
        DataCounters.Add(newcounter);
    }
    public void Add(Key key ,Value value){
        foreach(DataCounter counter in DataCounters){
            counter.Add(new Data(key,value));
        }
    }
    public bool Reduce(Key key ,Value value){
        foreach(DataCounter counter in DataCounters){
           if(counter.Reduce(key,value)){
               return true;
           }
        }
        return false;
    }
    public Value GetValue(Key key){
        foreach(DataCounter counter in DataCounters){
            Value value = counter.GetValue(key);
            if(!value.NullCheck()){
                return value;
            }
        }
        return new NullValue();
    }
}