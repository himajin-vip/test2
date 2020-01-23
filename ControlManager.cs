using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
  public MoveManager movemanager;
  public AtackManager atackmanager;
  public ManuManager manumanager;
  public ShortcutManager ShortcutManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(!atackmanager.AtackAnimation){
        if(Input.GetKey(KeyCode.M)){
          manumanager.ManuOn();
        }
        if(Input.GetKey(KeyCode.W)){
          movemanager.BackMove();
        }
        if(Input.GetKey(KeyCode.A)){
          movemanager.LeftMove();
        }
        if(Input.GetKey(KeyCode.D)){
          movemanager.RightMove();
        }
        if(Input.GetKey(KeyCode.S)){
          movemanager.FrontMove();
        }
        if(Input.GetKeyDown(KeyCode.Space)){
          atackmanager.AtackKeyDown();
        }
        if(Input.GetKeyUp(KeyCode.Space)){
          atackmanager.AtackKeyUp();
        }
        if(Input.GetKeyDown(KeyCode.U)){
          ShortcutManager.ItemUse();
        }

      }
    }
}
