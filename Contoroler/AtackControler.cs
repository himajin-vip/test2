using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackControler : MonoBehaviour
{
    Player Player;
    public  AtackControler(){
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    public void Check(){
        if(Input.GetKeyDown(KeyCode.M)){
            if(Player.Atack.KeyPush){
                Player.Atack.KeyUp();
            }
            MenuManager.SetMenuState("Main");
        }
        if(Input.GetKey(KeyCode.Space)){
            Player.Atack.KeyDown();
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            Player.Atack.KeyUp();
        }
    }
}
