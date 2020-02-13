
using System.Collections.Generic;
using UnityEngine;
public class ItemLibrary
{
    protected static Dictionary<int,ItemNames> ItemList = new Dictionary<int, ItemNames>();
    protected static Dictionary<int,Sprite> ItemImageList = new Dictionary<int,Sprite>();

    static ItemLibrary(){
        ItemList.Add(0,ItemNames.Potion);
        ItemList.Add(1,ItemNames.HiPotion);
        ItemList.Add(100,ItemNames.IronSword);
        ItemList.Add(200,ItemNames.LeatherCap);
        ItemList.Add(300,ItemNames.LeatherBody);
        ItemList.Add(400,ItemNames.LeatherHand);
        ItemList.Add(500,ItemNames.LeatherFoot);
        ItemImageList.Add(0,Resources.Load<Sprite>("ItemImage/Potion"));
        ItemImageList.Add(1,Resources.Load<Sprite>("ItemImage/HiPotion"));
    }

}
