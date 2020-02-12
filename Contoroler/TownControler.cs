﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownControler : Controler
{
    PlayerMoveControler PlayerMove;
    Player Player;

    public TownControler(){
        PlayerMove = new PlayerMoveControler();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    public void Check(){
        if(Input.GetKeyDown(KeyCode.M)){
            MenuManager.SetMenuState("Main");
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Player.Talk();
        }
        PlayerMove.Check();
    }
}
