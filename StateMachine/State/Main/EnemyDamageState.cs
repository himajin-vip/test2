using UnityEngine;
using System.Collections.Generic;
public class EnemyDamageState : IState
{
    SkillControler SkillControler;
    PlayerObjectManager player;
    public EnemyDamageState(SkillControler skill, PlayerObjectManager p){
        SkillControler = skill;
        player = p;
    }

    public void Start()
    {
        SkillControler.DamageCheck(player.GetPlayer());
        GameManager.SetState(States.Main);
    }

    public void Update()
    {

    }

    public void End()
    {

    }
}