using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InventoryManager
{
  private static Dictionary<int,int> Inventory = new Dictionary<int,int>();
    public static void SetUp()
    {
      Inventory.Clear();
      Inventory.Add (0, 3);
      Inventory.Add (100, 1);
    }
    static public void WeaponEquipment(int ItemID,Weapon weapon){
      if(InventoryKeyCheck(ItemID)){
        WeaponItem Item = ItemManager.returnWeaponItem(ItemID);
        Item.WeaponEquipment(weapon);
      }
    }
    static public void ItemGet(int ItemID){
      if(InventoryKeyCheck(ItemID)){
        Inventory[ItemID]++;
      }else{
        Inventory.Add (ItemID, 1);
      }
    }
    static public void RemoveInventory(int ItemID){
      if(InventoryKeyCheck(ItemID)){
        Inventory.Remove(ItemID);
      }
    }
    static bool InventoryKeyCheck(int CheckID){
      List<int> ItemList = new List<int>(Inventory.Keys);
      foreach(int ItemID in ItemList) {
        if(ItemID == CheckID){
          return true;
        }
      }
      return false;
    }
    static bool InventoryPiecesCheck(int key){
      if(Inventory[key]>0){
        return true;
      }else{
        return false;
      }
    }
    static public int ReturnPieces(int ItemID){
      if(InventoryKeyCheck(ItemID)){
        return Inventory[ItemID];
      }else{
        return 0;
      }
    }
    static public void ItemReduce(int ItemID){
      if(InventoryKeyCheck(ItemID)){
        Inventory[ItemID]--;
        if(Inventory[ItemID] == 0){
          RemoveInventory(ItemID);
        }
      }
    }
}
