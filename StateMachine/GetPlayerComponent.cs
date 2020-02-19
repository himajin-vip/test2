using UnityEngine;
public class GetPlayerComponent{
    public Player Get(){
        return GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
}