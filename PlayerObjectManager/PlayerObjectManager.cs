using UnityEngine;
public class PlayerObjectManager
{
    GameObject PlayerObject;
    Animator PlayerAnimator;
    Player player;

    public void SetObject(){
        PlayerObject = GameObject.FindGameObjectWithTag("Player").gameObject;
        PlayerAnimator = PlayerObject.GetComponent<Animator>();
        player = PlayerObject.GetComponent<Player>();
    }
    public int GetDirection(){
        return PlayerAnimator.GetInteger("Direction");
    }
    public float GetPosX(){
        return PlayerObject.transform.position.x;
    }
    public float GetPosY(){
        return PlayerObject.transform.position.y;
    }
    public Player GetPlayer(){
        return player;
    }
}