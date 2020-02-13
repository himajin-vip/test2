using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControler : Controler
{
    public void Check(){
        if(Input.GetKeyDown(KeyCode.M)){
        MenuManager.MenuOff();
        }
        if(Input.GetKeyDown(KeyCode.W)){
        MenuManager.MenuCursolMove(1);
        new PlayAudio().Play(AudioList.CursolMove);
        }
        if(Input.GetKeyDown(KeyCode.S)){
        MenuManager.MenuCursolMove(0);
        new PlayAudio().Play(AudioList.CursolMove);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
        MenuManager.CursolOn();
        new PlayAudio().Play(AudioList.CursolOn);
        }
    }
}
