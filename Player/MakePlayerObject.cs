using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlayerObject
{
    public GameObject Object{get; private set;}
    public MakePlayerObject(){
        GameObject obj = (GameObject)Resources.Load("prefab/Player/Player");
        Object = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
    }
    
}
