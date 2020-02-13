using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemImage : ItemLibrary
{    
    public Sprite Get(ItemID itemID){
      return ItemImageList[itemID.GetValue()];
    }
}
