using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicDatas
{
    public List<string> publicdatas = new List<string>();
    public void Add(PublicData publicdata){
        publicdatas.Add(JsonUtility.ToJson(publicdata));
    }
}
