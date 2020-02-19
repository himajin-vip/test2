using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpaceManager
{
    Dictionary<GameObject,SpaceContoroler> SpacesList = new Dictionary<GameObject, SpaceContoroler>();
    SpaceContoroler SpaceContoroler;
    public SpaceManager(){
    }
    public void Check(){
        
    }
    public void SetState(SpaceStates nextstate){
        // space = Spaces[nextstate];
    }
}