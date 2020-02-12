using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownControler : Controler
{
    GameObject PlayerObj;
    Player Player;
    Move PlayerMove;
    public TownControler(){
        PlayerObj = GameObject.FindGameObjectWithTag("Player").gameObject;
        Player = GameManager.Player;
        PlayerMove = new Move(PlayerObj,Player.MoveSpeed.Value,Player.Direction);

    }
    public void Check(){
        if(Input.GetKeyDown(KeyCode.M)){
            MenuManager.SetMenuState("Main");
        }
        if(Input.GetKey(KeyCode.S)){
            PlayerMove.Down();
        }
        if(Input.GetKey(KeyCode.W)){
            PlayerMove.Up();
        }
        if(Input.GetKey(KeyCode.D)){
            PlayerMove.Right();
        }
        if(Input.GetKey(KeyCode.A)){
            PlayerMove.Left();
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            GameManager.Player.Talk();
        }
    }
}
