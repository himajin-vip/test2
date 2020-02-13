using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class InventoryPeaceTextSet
{
    public void Set(Text text , ItemID itemID){
        ItemPeace itemPeace = new InventoryGetPeace().Get(itemID);
        int peace = itemPeace.GetValue();
        text.text = peace.ToString();
    }
}
