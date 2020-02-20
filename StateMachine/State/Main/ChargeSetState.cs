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

    public void Start(StateData stateData)
    {
        Player Player = player.GetPlayer();
        Player.SetEfect(Efects.tame);
        GameManager.SetState(States.Main,new StateData());
    }

    public void Update()
    {

    }

    public void End(){

    }
}