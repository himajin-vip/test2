using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicDatasList
{
    public List<string> publicDatasList = new List<string>();
    public void Add(PublicDatas publicDatas){
        publicDatasList.Add(JsonUtility.ToJson(publicDatas));
    }
}
