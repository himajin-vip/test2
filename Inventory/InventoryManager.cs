using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryManager
{
    public static Dictionary<ItemType,Inventory> InventoryList{get; private set;} = new Dictionary<ItemType, Inventory>();
    private static int SelectItemNo;

    public static int Gold{get; private set;} = 0;

    public InventoryManager(){ 
      InventoryList.Clear();
      InventoryList.Add(ItemType.Use,new Inventory());
      InventoryList.Add(ItemType.Weapon,new Inventory());
      InventoryList.Add(ItemType.Body,new Inventory());
      InventoryList.Add(ItemType.Head,new Inventory());
      InventoryList.Add(ItemType.Hand,new Inventory());
      InventoryList.Add(ItemType.Foot,new Inventory());
      InventoryList.Add(ItemType.Accessory,new Inventory());
    }

    static public void ItemGet(DropItemObj Item){

      int ItemID = Item.ItemId;
      ItemType ItemType = ItemManager.ReturnItemType(ItemID);
      InventoryList[ItemType].Add(ItemID,1);
      
      AccountData.Save();
      
    }

    static public bool ItemBuy(int itemid, int itemnumber){
      int price = ItemManager.ReturnPrice(itemid)*itemnumber;

      if(PayGold(price)){

        ItemType ItemType = ItemManager.ReturnItemType(itemid);
        InventoryList[ItemType].Add(itemid,itemnumber);
        
        AccountData.Save();
        return true;
      }
      return false;

    }
    static public List<int> ReturnInventoryList(ItemType ItemType){
        return new List<int>(InventoryList[ItemType].ItemIDList);
    }
    static public List<int> ReturnInventoryNumberList(ItemType ItemType){
        return new List<int>(InventoryList[ItemType].ItemPeaceList);
    }

    public static int ReturnPieces(int ItemID){
      ItemType ItemType = ItemManager.ReturnItemType(ItemID);
        return InventoryList[ItemType].ReturnPeace(ItemID);
    }

    static public void ItemReduce(int ItemID){
      ItemType ItemType = ItemManager.ReturnItemType(ItemID);
      InventoryList[ItemType].Reduce(ItemID,1);
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

    public static void InventoryLoad(SaveData SaveData){
      InventoryList[ItemType.Use].Load(SaveData.UseItemList,SaveData.UseItemNumberList);
      InventoryList[ItemType.Weapon].Load(SaveData.WeaponItemList,SaveData.WeaponItemNumberList);
      InventoryList[ItemType.Head].Load(SaveData.HeadItemList,SaveData.HeadItemNumberList);
      InventoryList[ItemType.Body].Load(SaveData.BodyItemList,SaveData.BodyItemNumberList);
      InventoryList[ItemType.Hand].Load(SaveData.HandItemList,SaveData.HandItemNumberList);
      InventoryList[ItemType.Foot].Load(SaveData.FootItemList,SaveData.FootItemNumberList);
      InventoryList[ItemType.Accessory].Load(SaveData.AccesuryItemList,SaveData.AccesuryItemNumberList);
    }
}
