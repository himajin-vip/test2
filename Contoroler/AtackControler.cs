using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackControler
{
    Playerp Playerp;
    public  AtackControler(){
        Playerp = GameObject.FindGameObjectWithTag("Playerp").GetComponent<Playerp>();
    }
    public void Check(){
        if(Input.GetKeyDown(KeyCode.M)){
            if(Playerp.Atack.KeyPush){
                Playerp.Atack.KeyUp();
            }
            MenuManager.SetMenuState("Main");
        }
        if(Input.GetKey(KeyCode.Space)){
            Playerp.Atack.KeyDown();
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            Playerp.Atack.KeyUp();
        }
    }
}
