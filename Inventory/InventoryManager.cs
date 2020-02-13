using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryManager
{
    private static InventoryList inventoryList = new InventoryList();
    private static Wallet wallet = new Wallet();

    public void ItemGet(ItemID itemID , ItemPeace itemPeace){
      inventoryList.Add(itemID,itemPeace);
      AccountData.Save();
    }

    public bool ItemBuy(ItemID itemID, ItemPeace itemPeace){
      ItemLibrary itemLibrary = new ItemLibrary();
      Gold gold = itemLibrary.GetPrice(itemID,itemPeace);
      if(wallet.Use(gold)){
        ItemGet(itemID,itemPeace);
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
      ItemLibrary itemLibrary = new ItemLibrary();
      ItemType ItemType = itemLibrary.GetItemType(itemID);
      inventoryList.Reduce(itemID,itemPeace);
      AccountData.Save();
    }
    public Gold GetMoney(){
      return wallet.GetMoney();
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
