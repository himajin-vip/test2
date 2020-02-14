using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copy_ItemPeace
{
    public ItemPeace Copy(ItemPeace itemPeace){
        return new ItemPeace(itemPeace.GetValue());
    }
}
