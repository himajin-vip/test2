using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectManager : MonoBehaviour
{
  public MoveManager movemanager;
  public Enemy enemy;
  public GameObject efect;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject efecton(float efectposx , float efectposy, GameObject obj_parent){
      GameObject obj = Instantiate(efect, new Vector3(efectposx,efectposy,0), transform.rotation,obj_parent.transform);
      return obj;
    }
}
