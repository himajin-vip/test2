using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EfectManager
{

    public static Efect efecton(string efectname ,float efectposx , float efectposy, GameObject obj_parent){
      GameObject obj = (GameObject)Resources.Load ("prefab/Efect/"+efectname);
      Efect efect = obj.GetComponent<Efect>();
      efect.SetUp(efectposx,efectposy,obj_parent);
      return efect;
    }
}
