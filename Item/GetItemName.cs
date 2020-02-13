﻿using System;
public class GetItemName : ItemLibrary
{
    public ItemName Get(ItemID itemID){
        ItemNames itemname = ItemList[itemID.GetID()];
        Type itemtype = Type.GetType(itemname.ToString());
        Item item = (Item)Activator.CreateInstance(itemtype);
        return item.GetName();
    }
}
