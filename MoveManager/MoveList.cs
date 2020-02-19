using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveList
{
    Dictionary<GameObject,Move> Moves = new Dictionary<GameObject, Move>();

    public void Add(GameObject obj,Move move){
        Moves.Add(obj,move);
    }
    public void Remove(GameObject obj){
        Moves.Remove(obj);
    }
    public bool Find(GameObject obj){
        return Moves.ContainsKey(obj);
    }
    public void Change(GameObject obj,Move move){
        Moves[obj] = move;
    }
    public void Check(){
        foreach(Move move in Moves.Values){
            move.Check();
        }
    }
}