using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ItemLibrary
{
    private Dictionary<int,ItemName> ItemList = new Dictionary<int, ItemName>();

    public ItemLibrary(){
        ItemList.Add(0,ItemName.Potion);
        ItemList.Add(1,ItemName.HiPotion);
        ItemList.Add(100,ItemName.IronSword);
        ItemList.Add(200,ItemName.LeatherCap);
        ItemList.Add(300,ItemName.LeatherBody);
        ItemList.Add(400,ItemName.LeatherHand);
        ItemList.Add(500,ItemName.LeatherFoot);
    }

    public ItemType GetItemType(ItemID itemID){
        ItemName itemname = ItemList[itemID.GetID()];
        Type itemtype = Type.GetType(itemname.ToString());
        Item item = (Item)Activator.CreateInstance(itemtype);
        return item.Type;
    }
    public Gold GetPrice(ItemID itemID,ItemPeace itemPeace){
        ItemName itemname = ItemList[itemID.GetID()];
        Type itemtype = Type.GetType(itemname.ToString());
        Item item = (Item)Activator.CreateInstance(itemtype);
        return new Gold(item.Price*itemPeace.GetValue());
    }
    public UseItem GetUseItem(ItemID itemID){
        ItemName itemname = ItemList[itemID.GetID()];
        Type itemtype = Type.GetType(itemname.ToString());
        UseItem item = (UseItem)Activator.CreateInstance(itemtype);
        return item;
    }

}
