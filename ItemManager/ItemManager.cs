using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemManager
{
  private static Dictionary<int,UseItem> UseItemList = new Dictionary<int,UseItem>();
  private static Dictionary<int,WeaponItem> WeaponItemList = new Dictionary<int,WeaponItem>();
  private static Dictionary<int,string> ItemNameList = new Dictionary<int,string>();
  private static GameObject DropItemprefab;



    public static void SetUp(){//Excelとかで読み込めないかな
      UseItemList.Clear();
      WeaponItemList.Clear();
      ItemNameList.Clear();
      UseItem item = new Potion();
      UseItemList.Add(0,item);
      ItemNameList.Add(0,"ポーション");

      WeaponItem weaponitem = new IronSword();
      WeaponItemList.Add(100,weaponitem);
      ItemNameList.Add(100,"鉄の剣");

      DropItemprefab = (GameObject)Resources.Load ("prefab/DropItem");
    }
    public static string returnItemName(int ItemID){
      return ItemNameList[ItemID];
    }
    public static UseItem returnUseItem(int ItemID){
      return UseItemList[ItemID];
    }
    public static WeaponItem returnWeaponItem(int ItemID){
      return WeaponItemList[ItemID];
    }
    public static void DropItemMake(int ItemID,float x,float y){
      GameObject DropItem = GameObject.Instantiate(DropItemprefab, new Vector3(x,y,0), Quaternion.identity);
      DropItem dropitem = DropItem.GetComponent<DropItem>();
      dropitem.SetUp(ItemID,x,y);
    }

}
