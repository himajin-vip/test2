﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efect : MonoBehaviour
{
  public void SetUp(float efectposx , float efectposy,GameObject obj_parent){
    Instantiate(this, new Vector3(efectposx,efectposy,0), Quaternion.identity);
    GetComponent<Efect>().SetParent(obj_parent);
  }
  public void OnEnd(){
    Destroy(this.gameObject);
  }
  public void SetParent(GameObject obj_parent){
    this.transform.parent = obj_parent.transform;
  }
}
