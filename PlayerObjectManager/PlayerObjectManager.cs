using UnityEngine;
public class PlayerObjectManager
{
    GameObject PlayerObject;
    Animator PlayerAnimator;

    public void SetObject(){
        PlayerObject = GameObject.FindGameObjectWithTag("Player").gameObject;
        PlayerAnimator = PlayerObject.GetComponent<Animator>();
    }
    public GameObject GetObject(){
        return PlayerObject;
    }
    public Animator GetAnimator(){
        return PlayerAnimator;
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
}