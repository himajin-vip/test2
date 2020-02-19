using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private Dictionary<States,IState> StateList = new Dictionary<States, IState>();
    private IState State = new nullState();

    public void Update(){
        State.Update();
    }
    public void Start(States nextstate){
        State = StateList[nextstate];
        State.Start();
    }

    public void Set(States nextstate){
        State.End();
        State = StateList[nextstate];
        State.Start();
    }
    public void Add(States statename,IState newstate){
        StateList.Add(statename,newstate);
    }
}
