using System;

public class GetItemType : ItemLibrary
{
    public ItemType Get(ItemID itemID){
        ItemNames itemname = ItemList[itemID.GetValue()];
        Type itemtype = Type.GetType(itemname.ToString());
        Item item = (Item)Activator.CreateInstance(itemtype);
        return item.getType();
    }
}
