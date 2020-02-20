using UnityEngine;
using System.Collections.Generic;
public class AtackState : IState
{
    SkillControler SkillControler;
    PlayerObjectManager player;
    MoveManager Move;
    public AtackState(SkillControler skill, PlayerObjectManager p,MoveManager m){
        SkillControler = skill;
        player = p;
        Move = m;
    }

    public void Start(StateData state)
    {
        SkillControler.SkillOn(player);
        Move.SetState(MoveState.Atack);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            GameManager.SetState(States.ChargeSetState,new StateData());
        }

    }

    public void End(){
    }
}