using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControler : Controler
{
    GameObject PlayerObj;
    Player Player;
    Move PlayerMove;
    public MainControler(){
        PlayerObj = GameObject.FindGameObjectWithTag("Player").gameObject;
        Player = GameManager.Player;
        PlayerMove = new Move(PlayerObj,Player.MoveSpeed.Value,Player.Direction);

    }
    public void Check(){
        if(Input.GetKeyDown(KeyCode.M)){
            if(GameManager.Player.Atack.KeyPush){
                GameManager.Player.Atack.KeyUp();
            }
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
        if(Input.GetKey(KeyCode.Space)){
            GameManager.Player.Atack.KeyDown();
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            GameManager.Player.Atack.KeyUp();
        }
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            ShortcutManager.ShortCutOn(1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            ShortcutManager.ShortCutOn(2);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3)){
            ShortcutManager.ShortCutOn(3);
        }
        if(Input.GetKeyDown(KeyCode.Alpha4)){
            ShortcutManager.ShortCutOn(4);
        }
    }
}
