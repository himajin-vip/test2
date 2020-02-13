using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryManager
{
    private static InventoryList inventoryList = new InventoryList();
    private ItemLibrary itemLibrary = new ItemLibrary();
    private static int SelectItemNo;
    public static int Gold{get; private set;} = 0;

    public void ItemGet(DropItemObj Item){
      inventoryList.Add(new ItemID(Item.ItemId),new ItemPeace(1));
      AccountData.Save();
      
    }

    public bool ItemBuy(ItemID itemID, ItemPeace itemPeace){
      int price = itemLibrary.GetPrice(itemID)*itemPeace.GetPeace();
      if(PayGold(price)){
        ItemType ItemType = itemLibrary.GetItemType(itemID);
        inventoryList.Add(itemID,itemPeace);
        AccountData.Save();
        return true;
      }
      return false;
    }
    public List<int> GetIdList(ItemType ItemType){
        return inventoryList.GetIdList(ItemType);
    }
    public List<int> GetPeaceList(ItemType ItemType){
        return inventoryList.GetPeaceList(ItemType);
    }

    public ItemPeace GetPieces(ItemID itemID){
        return inventoryList.GetPeace(itemID);
    }

    public void Reduce(ItemID itemID,ItemPeace itemPeace){
      ItemType ItemType = itemLibrary.GetItemType(itemID);
      inventoryList.Reduce(itemID,itemPeace);
      AccountData.Save();
    }
    /////////////////インベントリで選択したアイテムの保存
    static public void SelectItem(int ItemID){
      SelectItemNo = ItemID;
    }
    static public int ReturnSelectItem(){
      return SelectItemNo;
    }

    static public void GetGold(int gold){
      Gold += gold;
    }
    static public bool PayGold(int gold){
      if(Gold-gold >= 0){
        Gold -= gold;
        return true;
      }
      return false;
    }

    public void InventoryLoad(SaveData SaveData){
      inventoryList.Load(SaveData.UseItemList,SaveData.UseItemNumberList);
      inventoryList.Load(SaveData.WeaponItemList,SaveData.WeaponItemNumberList);
      inventoryList.Load(SaveData.HeadItemList,SaveData.HeadItemNumberList);
      inventoryList.Load(SaveData.BodyItemList,SaveData.BodyItemNumberList);
      inventoryList.Load(SaveData.HandItemList,SaveData.HandItemNumberList);
      inventoryList.Load(SaveData.FootItemList,SaveData.FootItemNumberList);
      inventoryList.Load(SaveData.AccesuryItemList,SaveData.AccesuryItemNumberList);
    }
}
