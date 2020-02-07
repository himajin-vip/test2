using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownKey : Key
{
    public void Check(){
        if(Input.GetKeyDown(KeyCode.M)){
            MenuManager.SetMenuState("Main");
        }
        if(Input.GetKey(KeyCode.S)){
            PlayerManager.Player.Move.Down();
        }
        if(Input.GetKey(KeyCode.W)){
            PlayerManager.Player.Move.Up();
        }
        if(Input.GetKey(KeyCode.D)){
            PlayerManager.Player.Move.Right();
        }
        if(Input.GetKey(KeyCode.A)){
            PlayerManager.Player.Move.Left();
        }
        if(Input.GetKeyDown(KeyCode.Space)){
        //喋る
        }
    }
}
