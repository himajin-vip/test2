using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InventoryManager
{
    private static Dictionary<int,int> UseItemInventory = new Dictionary<int,int>();
    private static Dictionary<int,int> WeaponItemInventory = new Dictionary<int,int>();
    private static Dictionary<int,int> HeadItemInventory = new Dictionary<int,int>();
    private static Dictionary<int,int> BodyItemInventory = new Dictionary<int,int>();
    private static Dictionary<int,int> HandItemInventory = new Dictionary<int,int>();
    private static Dictionary<int,int> FootItemInventory = new Dictionary<int,int>();
    private static Dictionary<int,int> AccesuryItemInventory = new Dictionary<int,int>();
    private static int SelectItemNo;

    public static void SetUp(){
      UseItemInventory.Clear();
      WeaponItemInventory.Clear();
      HeadItemInventory.Clear();
      BodyItemInventory.Clear();
      HandItemInventory.Clear();
      FootItemInventory.Clear();
      AccesuryItemInventory.Clear();

      UseItemInventory.Add (0, 3);
      UseItemInventory.Add (1,99);
      WeaponItemInventory.Add (100, 1);
    }
    static public void WeaponEquip(int ItemID){
      if(InventoryKeyCheck(ItemID)){
        WeaponItem Item = ItemManager.returnWeaponItem(ItemID);
        Item.WeaponEquip();
      }
    }
    static public void ItemGet(int ItemID){
      string ItemType = ItemManager.returnItemType(ItemID);

      if(InventoryKeyCheck(ItemID)){
        switch(ItemType){
          case "UseItem":
            UseItemInventory[ItemID]++;
          break;
          case "WeaponItem":
            WeaponItemInventory[ItemID]++;
          break;
          case "HeadItem":
            HeadItemInventory[ItemID]++;
          break;
          case "BodyItem":
            BodyItemInventory[ItemID]++;
          break;
          case "HandItem":
            HandItemInventory[ItemID]++;
          break;
          case "FootItem":
            FootItemInventory[ItemID]++;
          break;
          case "AccesuryItem":
            AccesuryItemInventory[ItemID]++;
          break;
        }
      }else{
        switch(ItemType){
          case "UseItem":
            UseItemInventory.Add (ItemID, 1);
          break;
          case "WeaponItem":
            WeaponItemInventory.Add (ItemID, 1);
          break;
          case "HeadItem":
            HeadItemInventory.Add (ItemID, 1);
          break;
          case "BodyItem":
            BodyItemInventory.Add (ItemID, 1);
          break;
          case "HandItem":
            HandItemInventory.Add (ItemID, 1);
          break;
          case "FootItem":
            FootItemInventory.Add (ItemID, 1);
          break;
          case "AccesuryItem":
            AccesuryItemInventory.Add (ItemID, 1);
          break;
        }
      }
    }
    static public List<int> ReturnInventoryList(string ItemType){
      switch(ItemType){
        case "UseItem":
          return new List<int>(UseItemInventory.Keys);

        case "WeaponItem":
          return new List<int>(WeaponItemInventory.Keys);

        case "HeadItem":
          return new List<int>(HeadItemInventory.Keys);

        case "BodyItem":
          return new List<int>(BodyItemInventory.Keys);

        case "HandItem":
          return new List<int>(HandItemInventory.Keys);

        case "FootItem":
          return new List<int>(FootItemInventory.Keys);

        case "AccesuryItem":
          return new List<int>(AccesuryItemInventory.Keys);

      }
      return new List<int>(0);
    }
    static bool InventoryKeyCheck(int CheckID){
      List<int> UseItemList = new List<int>(UseItemInventory.Keys);
      List<int> WeaponItemList = new List<int>(WeaponItemInventory.Keys);
      List<int> HeadItemList = new List<int>(HeadItemInventory.Keys);
      List<int> BodyItemList = new List<int>(BodyItemInventory.Keys);
      List<int> HandItemList = new List<int>(HandItemInventory.Keys);
      List<int> FootItemList = new List<int>(FootItemInventory.Keys);
      List<int> AccesuryItemList = new List<int>(AccesuryItemInventory.Keys);
      foreach(int ItemID in UseItemList) {
        if(ItemID == CheckID){
          return true;
        }
      }
      foreach(int ItemID in WeaponItemList) {
        if(ItemID == CheckID){
          return true;
        }
      }
      foreach(int ItemID in HeadItemList) {
        if(ItemID == CheckID){
          return true;
        }
      }
      foreach(int ItemID in BodyItemList) {
        if(ItemID == CheckID){
          return true;
        }
      }
      foreach(int ItemID in HandItemList) {
        if(ItemID == CheckID){
          return true;
        }
      }
      foreach(int ItemID in FootItemList) {
        if(ItemID == CheckID){
          return true;
        }
      }
      foreach(int ItemID in AccesuryItemList) {
        if(ItemID == CheckID){
          return true;
        }
      }
      return false;
    }
    static bool InventoryPiecesCheck(int ItemID){
      string ItemType = ItemManager.returnItemType(ItemID);
      switch(ItemType){
        case "UseItem":
        if(UseItemInventory[ItemID]>0){
          return true;
        }else{
          return false;
        }
        case "WeaponItem":
        if(WeaponItemInventory[ItemID]>0){
          return true;
        }else{
          return false;
        }
        case "HeadItem":
        if(HeadItemInventory[ItemID]>0){
          return true;
        }else{
          return false;
        }
        case "BodyItem":
        if(BodyItemInventory[ItemID]>0){
          return true;
        }else{
          return false;
        }
        case "HandItem":
        if(HandItemInventory[ItemID]>0){
          return true;
        }else{
          return false;
        }
        case "FootItem":
        if(FootItemInventory[ItemID]>0){
          return true;
        }else{
          return false;
        }
        case "AccesuryItem":
        if(AccesuryItemInventory[ItemID]>0){
          return true;
        }else{
          return false;
        }
      }
      return false;
    }
    static public int ReturnPieces(int ItemID){
      string ItemType = ItemManager.returnItemType(ItemID);
      if(InventoryKeyCheck(ItemID)){
        switch(ItemType){
          case "UseItem":
            return UseItemInventory[ItemID];
          case "WeaponItem":
            return WeaponItemInventory[ItemID];
          case "HeadItem":
            return HeadItemInventory[ItemID];
          case "BodyItem":
            return BodyItemInventory[ItemID];
          case "HandItem":
            return HandItemInventory[ItemID];
          case "FootItem":
            return FootItemInventory[ItemID];
          case "AccesuryItem":
            return AccesuryItemInventory[ItemID];
        }

      }else{
        return 0;
      }
      return 0;
    }
    static public void ItemReduce(int ItemID){
      string ItemType = ItemManager.returnItemType(ItemID);
      if(InventoryKeyCheck(ItemID)){
        switch(ItemType){
          case "UseItem":
            UseItemInventory[ItemID]--;
            if(UseItemInventory[ItemID]<=0){
              Debug.Log("RemoveItem");
              UseItemInventory.Remove(ItemID);
            }
          break;
          case "WeaponItem":
            WeaponItemInventory[ItemID]--;
            if(WeaponItemInventory[ItemID]<=0){
              WeaponItemInventory.Remove(ItemID);
            }
          break;
          case "HeadItem":
            HeadItemInventory[ItemID]--;
            if(HandItemInventory[ItemID]<=0){
              HandItemInventory.Remove(ItemID);
            }
          break;
          case "BodyItem":
            BodyItemInventory[ItemID]--;
            if(BodyItemInventory[ItemID]<=0){
              BodyItemInventory.Remove(ItemID);
            }
          break;
          case "HandItem":
            HandItemInventory[ItemID]--;
            if(HandItemInventory[ItemID]<=0){
              HandItemInventory.Remove(ItemID);
            }
          break;
          case "FootItem":
            FootItemInventory[ItemID]--;
            if(FootItemInventory[ItemID]<=0){
              FootItemInventory.Remove(ItemID);
            }
          break;
          case "AccesuryItem":
            AccesuryItemInventory[ItemID]--;
            if(AccesuryItemInventory[ItemID]<=0){
              AccesuryItemInventory.Remove(ItemID);
            }
          break;
        }
      }
    }
    /////////////////インベントリで選択したアイテムの保存
    static public void SelectItem(int ItemID){
      SelectItemNo = ItemID;
    }
    static public int ReturnSelectItem(){
      return SelectItemNo;
    }
}
