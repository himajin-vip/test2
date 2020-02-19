using UnityEngine;
using System.Collections.Generic;
public class AtackState : IState
{
    SkillControler SkillControler;
    PlayerObjectManager player;
    public AtackState(SkillControler skill, PlayerObjectManager p){
        SkillControler = skill;
        player = p;
    }

    public void Start()
    {
        SkillControler.SkillOn(player);
        GameManager.SetState(States.Main);
    }

    public void Update()
    {

    }

    public void End()
    {

    }
}