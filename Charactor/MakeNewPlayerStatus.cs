using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MakeNewPlayerStatus
{
    public StatusCounter Make(){
        
        int[] status = new int[12] {1,100,100,10,10,1,2,3,4,0,100,1000};
        string name = "Test";
        List<Statuss> list = new List<Statuss>();
        foreach (Statuss Value in Enum.GetValues(typeof(Statuss))){
            if(Value != Statuss.Name){
                list.Add(Value);
            }
        }

        StatusCounter statusCounter = new StatusCounter();
        Key key;
        Value value;

        for(int i = 0; i<list.Count;i++){
            key = new StringKey(list[i].ToString(),DataType_Charactor.Status.ToString());
            value = new IntValue(status[i]);
            statusCounter.Add(new Data(key,value));
        }

        key = new StringKey(Statuss.Name.ToString(),DataType_Charactor.Status.ToString());
        value = new StringValue(name);
        statusCounter.Add(new Data(key,value));
        
        return statusCounter;
    }
}