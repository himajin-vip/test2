using System;

public class Get_ItemType : ItemLibrary
{
    public ItemType forItemID(ItemID itemID){
        ItemNames itemname = ItemList[itemID.GetValue()];
        Type itemtype = Type.GetType(itemname.ToString());
        Item item = (Item)Activator.CreateInstance(itemtype);
        return item.getType();
    }
    public ItemType forItemBag(ItemBag itemBag){
        return forItemID(new Get_ItemID_ItemBag().Get(itemBag));
    }
    
}
