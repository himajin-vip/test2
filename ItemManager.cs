using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemManager
{
  private static Dictionary<int,UseItem> UseItemList = new Dictionary<int,UseItem>();
  private static Dictionary<int,WeaponItem> WeaponItemList = new Dictionary<int,WeaponItem>();


    public static void SetUp(){//Excelとかで読み込めないかな
      Debug.Log("ItemManagerを初期化します");
      UseItem item = new Potion();
      UseItemList.Add(0,item);
      WeaponItem weaponitem = new IronSword();
      WeaponItemList.Add(100,weaponitem);
      Debug.Log("ItemManagerを初期化完了");
    }
    public static UseItem returnUseItem(int ItemID){
      return UseItemList[ItemID];
    }
    public static WeaponItem returnWeaponItem(int ItemID){
      return WeaponItemList[ItemID];
    }
    public static void DropItemMake(int ItemID,float x,float y){
      GameObject obj = (GameObject)Resources.Load ("prefab/DropItem");
      DropItem DropItem = obj.GetComponent<DropItem>();
      DropItem.SetUp(ItemID,x,y);
    }

}
