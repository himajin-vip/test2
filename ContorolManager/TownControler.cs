using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownControler : Controler
{
    public void Check(){
        if(Input.GetKeyDown(KeyCode.M)){
            MenuManager.SetMenuState("Main");
        }
        if(Input.GetKey(KeyCode.S)){
            GameManager.Player.Move.Down();
        }
        if(Input.GetKey(KeyCode.W)){
            GameManager.Player.Move.Up();
        }
        if(Input.GetKey(KeyCode.D)){
            GameManager.Player.Move.Right();
        }
        if(Input.GetKey(KeyCode.A)){
            GameManager.Player.Move.Left();
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            GameManager.Player.Talk();
        }
    }
}
