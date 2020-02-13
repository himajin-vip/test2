using System;

public class GetItem : ItemLibrary
{
    public Type Get(ItemID itemID){
        ItemNames itemname = ItemList[itemID.GetID()];
        return Type.GetType(itemname.ToString());
    }
}
