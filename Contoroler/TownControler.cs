using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownControler : Controler
{
    // PlayerpMoveControler PlayerpMove;
    Playerp Playerp;

    public TownControler(){
        // PlayerpMove = new PlayerpMoveControler();
        Playerp = GameObject.FindGameObjectWithTag("Playerp").GetComponent<Playerp>();
    }
    public void Check(){
        if(Input.GetKeyDown(KeyCode.M)){
            MenuManager.SetMenuState("Main");
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Playerp.Talk();
        }
        // PlayerpMove.Check();
    }
}
