using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
  static Dictionary<int,int> Inventory = new Dictionary<int,int>();

    static public void SetUp()
    {
      if(InventoryCheck(0)){
        Inventory[0] = 3;
      }else{
        Inventory.Add (0, 3);
      }
    }

    static public void ItemGet(int ID){
      if(InventoryCheck(ID)){
        Inventory[ID]++;
      }else{
        Inventory.Add (ID, 1);
      }
    }
    static bool InventoryCheck(int Checkkey){
      List<int> keyList = new List<int>(Inventory.Keys);
      foreach(int key in keyList) {
        if(key == Checkkey){
          return true;
        }
      }
      return false;
    }
    static public int ReturnPieces(int key){
      return Inventory[key];
    }
    static public void ItemReduce(int key){
      Inventory[key]--;
    }
}
