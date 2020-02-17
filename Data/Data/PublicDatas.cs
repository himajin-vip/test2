using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicDatas
{
    public List<PublicData> publicdatas = new List<PublicData>();
    public void Add(PublicData publicdata){
        publicdatas.Add(publicdata);
    }
}
