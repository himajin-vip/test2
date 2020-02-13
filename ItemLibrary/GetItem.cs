using System;

public class GetItem : ItemLibrary
{
    public Type Get(ItemID itemID){
        ItemNames itemname = ItemList[itemID.GetValue()];
        return Type.GetType(itemname.ToString());
    }
}
