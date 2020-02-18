using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerpMoveControler
{
    Playerp Playerp;
    public PlayerpMoveControler(){
        Playerp = GameObject.FindGameObjectWithTag("Playerp").gameObject.GetComponent<Playerp>();

    }

    public void Check(){
        if(Input.GetKey(KeyCode.S)){
            Playerp.Move(0);
        }
        if(Input.GetKey(KeyCode.W)){
            Playerp.Move(1);
        }
        if(Input.GetKey(KeyCode.D)){
            Playerp.Move(2);
        }
        if(Input.GetKey(KeyCode.A)){
            Playerp.Move(3);
        }
    }



}
