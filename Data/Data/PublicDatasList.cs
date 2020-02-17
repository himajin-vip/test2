using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicDatasList
{
    List<PublicDatas> publicDatasList = new List<PublicDatas>();
    public void Add(PublicDatas publicDatas){
        publicDatasList.Add(publicDatas);
    }
}
