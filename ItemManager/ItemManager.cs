﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public static class ItemManager
{
  private static Dictionary<int,string> ItemNameList = new Dictionary<int,string>();
  private static Dictionary<int,Sprite> ItemImageList = new Dictionary<int,Sprite>();

  private static Dictionary<int,UseItem> UseItemList = new Dictionary<int,UseItem>();
  private static Dictionary<int,WeaponItem> WeaponItemList = new Dictionary<int,WeaponItem>();
  private static Dictionary<int,HeadItem> HeadItemList = new Dictionary<int,HeadItem>();
  private static Dictionary<int,BodyItem> BodyItemList = new Dictionary<int,BodyItem>();
  private static Dictionary<int,HandItem> HandItemList = new Dictionary<int,HandItem>();
  private static Dictionary<int,FootItem> FootItemList = new Dictionary<int,FootItem>();
  private static Dictionary<int,AccessoryItem> AccessoryItemList = new Dictionary<int,AccessoryItem>();
  private static GameObject DropItemprefab;



    public static void SetUp(){//Excelとかで読み込めないかな
      UseItemList.Clear();
      WeaponItemList.Clear();
      ItemNameList.Clear();
      ItemImageList.Clear();


      UseItemList.Add(0,new Potion());
      ItemNameList.Add(0,"ポーション");
      ItemImageList.Add(0,Resources.Load<Sprite>("ItemImage/Potion"));

      UseItemList.Add(1,new HiPotion());
      ItemNameList.Add(1,"ハイポーション");
      ItemImageList.Add(1,Resources.Load<Sprite>("ItemImage/HiPotion"));

      WeaponItemList.Add(100,new IronSword());
      ItemNameList.Add(100,"鉄の剣");

      HeadItemList.Add(200,new LeatherCap());
      ItemNameList.Add(200,"皮の帽子");

      BodyItemList.Add(300,new LeatherBody());
      ItemNameList.Add(300,"皮の服");

      HandItemList.Add(400,new LeatherHand());
      ItemNameList.Add(400,"皮の手袋");

      FootItemList.Add(500,new LeatherFoot());
      ItemNameList.Add(500,"皮の靴");



      DropItemprefab = (GameObject)Resources.Load ("prefab/DropItem");
    }
    public static string returnItemType(int CheckID){
      List<int> UseItemKeys = new List<int>(UseItemList.Keys);
      List<int> WeaponItemKeys = new List<int>(WeaponItemList.Keys);
      List<int> HeadItemKeys = new List<int>(HeadItemList.Keys);
      List<int> BodyItemKeys = new List<int>(BodyItemList.Keys);
      List<int> HandItemKeys = new List<int>(HandItemList.Keys);
      List<int> FootItemKeys = new List<int>(FootItemList.Keys);
      List<int> AccessoryItemKeys = new List<int>(AccessoryItemList.Keys);

      foreach(int ItemID in UseItemKeys) {
        if(ItemID == CheckID){
          return "UseItem";
        }
      }
      foreach(int ItemID in WeaponItemKeys) {
        if(ItemID == CheckID){
          return "WeaponItem";
        }
      }
      foreach(int ItemID in HeadItemKeys) {
        if(ItemID == CheckID){
          return "HeadItem";
        }
      }
      foreach(int ItemID in BodyItemKeys) {
        if(ItemID == CheckID){
          return "BodyItem";
        }
      }
      foreach(int ItemID in HandItemKeys) {
        if(ItemID == CheckID){
          return "HandItem";
        }
      }
      foreach(int ItemID in FootItemKeys) {
        if(ItemID == CheckID){
          return "FootItem";
        }
      }
      foreach(int ItemID in AccessoryItemKeys) {
        if(ItemID == CheckID){
          return "AccessoryItem";
        }
      }

      return "";
    }
    public static string ReturnInfo(int ItemID){
      string ItemType = returnItemType(ItemID);
      switch(ItemType){
        case "UseItem":
        return UseItemList[ItemID].ReturnInfo();
        case "WeaponItem":
        return WeaponItemList[ItemID].ReturnInfo();
        case "HeadItem":
        return HeadItemList[ItemID].ReturnInfo();
        case "BodyItem":
        return BodyItemList[ItemID].ReturnInfo();
        case "HandItem":
        return HandItemList[ItemID].ReturnInfo();
        case "FootItem":
        return FootItemList[ItemID].ReturnInfo();
        case "AccessoryItem":
        return AccessoryItemList[ItemID].ReturnInfo();
      }
      return "";
    }
    public static string returnItemName(int ItemID){
      string ItemName = "";
      foreach(int id in ItemNameList.Keys){
        if(id == ItemID){
          ItemName = ItemNameList[ItemID];
        }
      }
      return ItemName;
    }
    public static Sprite ReturnImage(int ItemID){
      return ItemImageList[ItemID];
    }

    public static UseItem returnUseItem(int ItemID){
      return UseItemList[ItemID];
    }
    public static WeaponItem returnWeaponItem(int ItemID){
      return WeaponItemList[ItemID];
    }
    public static HeadItem returnHeadItem(int ItemID){
      return HeadItemList[ItemID];
    }
    public static BodyItem returnBodyItem(int ItemID){
      return BodyItemList[ItemID];
    }
    public static HandItem returnHandItem(int ItemID){
      return HandItemList[ItemID];
    }
    public static FootItem returnFootItem(int ItemID){
      return FootItemList[ItemID];
    }
    public static AccessoryItem returnAccessoryItem(int ItemID){
      return AccessoryItemList[ItemID];
    }
    public static void DropItemMake(int ItemID,float x,float y){
      GameObject DropItem = GameObject.Instantiate(DropItemprefab, new Vector3(x,y,0), Quaternion.identity);
      DropItem dropitem = DropItem.GetComponent<DropItem>();
      dropitem.SetUp(ItemID,x,y);
    }

}
