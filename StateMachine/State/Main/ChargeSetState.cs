using UnityEngine;
using System.Collections.Generic;
public class ChargeSetState : IState
{
    SkillControler SkillControler;
    PlayerObjectManager player;
    public ChargeSetState(SkillControler skill, PlayerObjectManager p){
        SkillControler = skill;
        player = p;
    }

    public void Start()
    {
        Debug.Log("Charge");
        Player Player = player.GetPlayer();
        Player.SetEfect(Efects.tame);
        GameManager.ReturnState();
    }

    public void Update()
    {

    }

    public void End()
    {

    }
}