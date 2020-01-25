using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InventoryManager
{
  private static Dictionary<int,int> Inventory = new Dictionary<int,int>();
  private static bool SetEnd = false;
    static public void SetUp()
    {
      if(!SetEnd){
        Inventory.Add (0, 3);
        Inventory.Add (1, 1);
        SetEnd = true;
      }
    }
    static public int Equipment(int ItemID){
      if(InventoryKeyCheck(ItemID)){
        if(InventoryPiecesCheck(ItemID,1)){
          GameObject ItemObj = ItemManager.returnItemObject(ItemID);
          return ItemObj.GetComponent<IItem>().ItemSet();
        }
        return 0;
      }
      return 0;
    }
    static public void ItemGet(int ID){
      if(InventoryKeyCheck(ID)){
        Inventory[ID]++;
      }else{
        Inventory.Add (ID, 1);
      }
    }
    static bool InventoryKeyCheck(int Checkkey){
      List<int> keyList = new List<int>(Inventory.Keys);
      foreach(int key in keyList) {
        if(key == Checkkey){
          return true;
        }
      }
      return false;
    }
    static bool InventoryPiecesCheck(int key,int pieces){
      if(Inventory[key]>=pieces){
        return true;
      }else{
        return false;
      }
    }
    static public int ReturnPieces(int key){
      return Inventory[key];
    }
    static public void ItemReduce(int key){
      Inventory[key]--;
    }
}
