using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveControler
{
    Player Player;
    public PlayerMoveControler(){
        Player = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<Player>();

    }

    public void Check(){
        if(Input.GetKey(KeyCode.S)){
            Player.Move(0);
        }
        if(Input.GetKey(KeyCode.W)){
            Player.Move(1);
        }
        if(Input.GetKey(KeyCode.D)){
            Player.Move(2);
        }
        if(Input.GetKey(KeyCode.A)){
            Player.Move(3);
        }
    }



}
