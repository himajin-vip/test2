using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveManager
{
    Dictionary<MoveState,MoveList> MovesList = new Dictionary<MoveState, MoveList>();
    MoveList moves;
    
    public MoveManager(){
        foreach(MoveState state in Enum.GetValues(typeof(MoveState))){
            MovesList.Add(state,new MoveList());
        }
        moves = MovesList[MoveState.Main];
    }

    public void Add(MoveState moveState,GameObject obj,Move move){
         MoveList moves = MovesList[moveState];
        if(!moves.Find(obj)){
            moves.Add(obj,move);
            return;
        }
        moves.Change(obj,move);
    }
    public void Remove(GameObject obj){
        foreach(MoveList move in MovesList.Values){
            if(move.Find(obj)){       
                move.Remove(obj);
            }
        }
    }
    public void Check(){
        moves.Check();
        RemoveCheck();
    }
    public void RemoveCheck(){
        foreach(MoveList move in MovesList.Values){
            move.RemoveCheck();
        }
    }
    public void SetState(MoveState state){
        moves = MovesList[state];
    }
}