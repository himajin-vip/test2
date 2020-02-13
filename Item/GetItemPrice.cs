using System;
public class GetItemPrice : ItemLibrary
{    
    public ItemPrice Get(ItemID itemID,ItemPeace itemPeace){
        ItemNames itemname = ItemList[itemID.GetID()];
        Type itemtype = Type.GetType(itemname.ToString());
        Item item = (Item)Activator.CreateInstance(itemtype);
        return new PriceCal().Get(item.GetPrice(),itemPeace);
    }
}
