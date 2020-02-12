using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControler : Controler
{
    
    AtackControler Atack;
    PlayerMoveControler PlayerMove;
    ShortCutControler shortCut;
    public MainControler(){
        Atack = new AtackControler();
        PlayerMove = new PlayerMoveControler();
        shortCut = new ShortCutControler();

    }
    public void Check(){
        Atack.Check();
        shortCut.Check();
        PlayerMove.Check();
    }
}
