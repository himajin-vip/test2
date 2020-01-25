using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EfectManager
{

    public static GameObject efecton(string efectname ,float efectposx , float efectposy, GameObject obj_parent){
      GameObject efect = (GameObject)Resources.Load ("prefab/Efect/"+efectname);
      GameObject obj = GameManager.Instantiate(efect, new Vector3(efectposx,efectposy,0), Quaternion.identity);
      obj.GetComponent<Efect>().SetParent(obj_parent);
      return obj;
    }
}
