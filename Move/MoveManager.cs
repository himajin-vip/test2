using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveManager
{
    Dictionary<GameObject,Move> Moves = new Dictionary<GameObject, Move>();

    public void Add(GameObject obj,Move move){
        Moves.Add(obj,move);
    }
    public void Remove(GameObject obj){
        Moves.Remove(obj);
    }
    public void Check(){
        foreach(Move move in Moves.Values){
            move.Check();
        }
    }
}