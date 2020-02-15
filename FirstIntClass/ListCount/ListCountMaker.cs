using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ListCountMaker
{
    public ListCount forItemType(){
        return new ListCount(Enum.GetNames(typeof(ItemType)).Length);
    }
}
