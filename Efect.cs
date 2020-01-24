using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efect : MonoBehaviour
{
  public void OnEnd(){
    Destroy(this.gameObject);
  }
  public void SetParent(GameObject obj_parent){
    this.transform.parent = obj_parent.transform;
  }
}
