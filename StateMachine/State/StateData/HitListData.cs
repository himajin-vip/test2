using UnityEngine;
using System.Collections.Generic;
public class HitListData:StateData
{
    public HitListData(List<Enemy> Hit){
        Hitlist = Hit;
    }
}