using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectManager : MonoBehaviour
{
  public GameObject kamitukiefect;
  public GameObject kiriefect;
  public GameObject tameefect;
  public GameObject kaihukuefect;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject kamitukiefecton(float efectposx , float efectposy, GameObject obj_parent){
      GameObject obj = Instantiate(kamitukiefect, new Vector3(efectposx,efectposy,0), transform.rotation,obj_parent.transform);
      return obj;
    }
    public GameObject kiriefecton(float efectposx , float efectposy, GameObject obj_parent){
      GameObject obj = Instantiate(kiriefect, new Vector3(efectposx,efectposy,0), transform.rotation,obj_parent.transform);
      return obj;
    }
    public GameObject tameefecton(float efectposx , float efectposy, GameObject obj_parent){
      GameObject obj = Instantiate(tameefect, new Vector3(efectposx,efectposy,0), transform.rotation,obj_parent.transform);
      return obj;
    }
    public GameObject kaihukuefecton(float efectposx , float efectposy, GameObject obj_parent){
      GameObject obj = Instantiate(kaihukuefect, new Vector3(efectposx,efectposy,0), transform.rotation,obj_parent.transform);
      return obj;
    }
}
