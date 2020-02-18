using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlayerpObject
{
    public GameObject Object{get; private set;}
    public MakePlayerpObject(){
        GameObject obj = (GameObject)Resources.Load("prefab/Playerp/Playerp");
        Object = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
    }
    
}
