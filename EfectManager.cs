using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectManager : MonoBehaviour
{

    public static GameObject efecton(string efectname ,float efectposx , float efectposy, GameObject obj_parent){
      GameObject efect = (GameObject)Resources.Load ("prefab/Efect/"+efectname);
      GameObject obj = Instantiate(efect, new Vector3(efectposx,efectposy,0), Quaternion.identity);
      obj.GetComponent<Efect>().SetParent(obj_parent);
      return obj;
    }
}
