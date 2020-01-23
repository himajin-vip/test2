using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public AtackManager AtackManager;
  public bukimanager bukimanager;
    // Start is called before the first frame update
    void Start()
    {
      Initialize();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void Initialize(){
      Debug.Log("Initialize");
      AtackManager.AtackAnimation = false;
      AtackManager.atackon = false;
      AtackManager.ChargeEfectOn = false;
      AtackManager.fullcharge = false;
      AtackManager.keyup = false;
      bukimanager.atack_hit = false;
    }
}
