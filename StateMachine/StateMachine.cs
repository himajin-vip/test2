using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private Dictionary<string,IState> StateList = new Dictionary<string, IState>();
    private IState State = new nullState();

    public void Update(){
        State.Update();
    }
    public void Start(string nextstate){
        State = StateList[nextstate];
        State.Start();
    }

    public void Set(string nextstate){
        State.End();
        State = StateList[nextstate];
        State.Start();
    }
    public void Add(string statename,IState newstate){
        StateList.Add(statename,newstate);
    }
}
