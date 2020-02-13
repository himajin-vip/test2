using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
public class ItemLibrary
{
    private static Dictionary<int,ItemNames> ItemList = new Dictionary<int, ItemNames>();

    static ItemLibrary(){
        ItemList.Add(0,ItemNames.Potion);
        ItemList.Add(1,ItemNames.HiPotion);
        ItemList.Add(100,ItemNames.IronSword);
        ItemList.Add(200,ItemNames.LeatherCap);
        ItemList.Add(300,ItemNames.LeatherBody);
        ItemList.Add(400,ItemNames.LeatherHand);
        ItemList.Add(500,ItemNames.LeatherFoot);
    }

    public ItemType GetItemType(ItemID itemID){
        ItemNames itemname = ItemList[itemID.GetID()];
        Type itemtype = Type.GetType(itemname.ToString());
        Item item = (Item)Activator.CreateInstance(itemtype);
        return item.getType();
    }
    public ItemPrice GetPrice(ItemID itemID,ItemPeace itemPeace){
        ItemNames itemname = ItemList[itemID.GetID()];
        Type itemtype = Type.GetType(itemname.ToString());
        Item item = (Item)Activator.CreateInstance(itemtype);
        return new PriceCal().Get(item.GetPrice(),itemPeace);
    }
    public Type GetItem(ItemID itemID){
        ItemNames itemname = ItemList[itemID.GetID()];
        return Type.GetType(itemname.ToString());
    }
    public Text SetInfo(Text text,ItemID itemID){
        ItemNames itemname = ItemList[itemID.GetID()];
        Type itemtype = Type.GetType(itemname.ToString());
        Item item = (Item)Activator.CreateInstance(itemtype);
        ItemInfo itemInfo = item.GetInfo();
        text.text = itemInfo.GetValue();
        return text;
    }
    public Text SetName(Text text,ItemID itemID){
      ItemNames itemname = ItemList[itemID.GetID()];
      Type itemtype = Type.GetType(itemname.ToString());
      Item item = (Item)Activator.CreateInstance(itemtype);
      ItemName itemName = item.GetName();
      text.text = itemName.GetValue();
      return text;
    }

}
