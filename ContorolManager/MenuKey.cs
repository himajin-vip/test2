using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuKey : Key
{
    public void Check(){
        if(Input.GetKeyDown(KeyCode.M)){
        MenuManager.MenuOff();
        }
        if(Input.GetKeyDown(KeyCode.W)){
        MenuManager.MenuCursolMove(1);
        AudioManager.AudioON(1);
        }
        if(Input.GetKeyDown(KeyCode.S)){
        MenuManager.MenuCursolMove(0);
        AudioManager.AudioON(1);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
        MenuManager.CursolOn();
        AudioManager.AudioON(3);
        }
    }
}
