using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControler : Controler
{
    
    AtackControler Atack;
    // PlayerpMoveControler PlayerpMove;
    ShortCutControler shortCut;
    public MainControler(){
        Atack = new AtackControler();
        // PlayerpMove = new PlayerpMoveControler();
        shortCut = new ShortCutControler();

    }
    public void Check(){
        Atack.Check();
        shortCut.Check();
        // PlayerpMove.Check();
    }
}
