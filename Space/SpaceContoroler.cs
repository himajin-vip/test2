using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpaceContoroler
{
    Dictionary<SpaceStates,SpaceOn> Spaces = new Dictionary<SpaceStates, SpaceOn>();
    SpaceOn space;
    GameObject Object;
    public SpaceContoroler(){
        Spaces.Add(SpaceStates.Atack,new Atack_Space());
    }
    public void Check(){
        if(Input.GetKeyDown(KeyCode.Space)){
            space.KeyDown();
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            space.KeyUp();
        }
    }
    public void SetState(SpaceStates nextstate){
        space = Spaces[nextstate];
    }
}