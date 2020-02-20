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

    public void Start(StateData stateData)
    {
        SkillControler.DamageCheck(player.GetPlayer(),stateData.Hitlist);
        GameManager.SetState(States.Main,new StateData());
    }

    public void Update()
    {

    }

    public void End(){

    }
}