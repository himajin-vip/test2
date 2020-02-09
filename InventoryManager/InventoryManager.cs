using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class InventoryManager
{
    public static Dictionary<ItemType,Inventory> InventoryList{get; private set;} = new Dictionary<ItemType, Inventory>();
    private static int SelectItemNo;

    public static void SetUp(){ 
      InventoryList.Clear();
      InventoryList.Add(ItemType.Use,new Inventory());
      InventoryList.Add(ItemType.Weapon,new Inventory());
      InventoryList.Add(ItemType.Body,new Inventory());
      InventoryList.Add(ItemType.Head,new Inventory());
      InventoryList.Add(ItemType.Hand,new Inventory());
      InventoryList.Add(ItemType.Foot,new Inventory());
      InventoryList.Add(ItemType.Accessory,new Inventory());
      InventoryList[ItemType.Use].Add (0, 3);
      InventoryList[ItemType.Weapon].Add (100, 1);
      InventoryList[ItemType.Head].Add(200,1);
      InventoryList[ItemType.Body].Add(300,1);
      InventoryList[ItemType.Hand].Add(400,1);
      InventoryList[ItemType.Foot].Add(500,1);
    }

    static public void ItemGet(Collider2D collision){

      DropItemObj getItem = collision.gameObject.GetComponent<DropItemObj>();
      int ItemID = getItem.ItemId;
      new ItemGetLog(GameManager.Player.Name.Value,ItemID);
      getItem.DropEnd();

      ItemType ItemType = ItemManager.ReturnItemType(ItemID);
      InventoryList[ItemType].Add(ItemID,1);
      
      GameManager.AccountData.Save();
      
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
      GameManager.AccountData.Save();
    }
    /////////////////インベントリで選択したアイテムの保存
    static public void SelectItem(int ItemID){
      SelectItemNo = ItemID;
    }
    static public int ReturnSelectItem(){
      return SelectItemNo;
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
