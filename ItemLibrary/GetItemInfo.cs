using System;

public class GetItemInfo : ItemLibrary
{    
    public ItemInfo Get(ItemID itemID){
        ItemNames itemname = ItemList[itemID.GetValue()];
        Type itemtype = Type.GetType(itemname.ToString());
        Item item = (Item)Activator.CreateInstance(itemtype);
        return item.GetInfo();
    }
}
