﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ControlManager : MonoBehaviour
{
  public ManuManager manumanager;
  public ShortcutManager ShortcutManager;
    void Update()
    {
      if(!PlayerManager.Player.GetComponent<Player>().AtackAnimation){
        if(Input.GetKey(KeyCode.M)){
          manumanager.ManuOn();
        }
        if(Input.GetKey(KeyCode.W)){
          PlayerManager.Player.GetComponent<Player>().BackMove();
        }
        if(Input.GetKey(KeyCode.A)){
          PlayerManager.Player.GetComponent<Player>().LeftMove();
        }
        if(Input.GetKey(KeyCode.D)){
          PlayerManager.Player.GetComponent<Player>().RightMove();
        }
        if(Input.GetKey(KeyCode.S)){
          PlayerManager.Player.GetComponent<Player>().FrontMove();
        }
        if(Input.GetKeyDown(KeyCode.Space)){
          PlayerManager.Player.GetComponent<Player>().AtackKeyDown();
        }
        if(Input.GetKeyUp(KeyCode.Space)){
          PlayerManager.Player.GetComponent<Player>().AtackKeyUp();
        }
        if(Input.GetKeyDown(KeyCode.U)){
          ShortcutManager.ItemUse();
        }

      }
    }
}
