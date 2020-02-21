using UnityEngine;
using System.Collections.Generic;
public class PlayerFindData:StateData
{
    public PlayerFindData(Player p,Enemy e){
        player = p;
        enemy = e;
    }
}