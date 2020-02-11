using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public static class ItemManager
{
  private static Dictionary<int,Sprite> ItemImageList = new Dictionary<int,Sprite>();
  private static Dictionary<int,ItemName> ItemList = new Dictionary<int, ItemName>();
  private static GameObject DropItemprefab;



    static ItemManager(){//Excelとかで読み込めないかな
      ItemList.Add(0,ItemName.Potion);
      ItemList.Add(1,ItemName.HiPotion);
      ItemList.Add(100,ItemName.IronSword);
      ItemList.Add(200,ItemName.LeatherCap);
      ItemList.Add(300,ItemName.LeatherBody);
      ItemList.Add(400,ItemName.LeatherHand);
      ItemList.Add(500,ItemName.LeatherFoot);

      ItemImageList.Add(0,Resources.Load<Sprite>("ItemImage/Potion"));
      ItemImageList.Add(1,Resources.Load<Sprite>("ItemImage/HiPotion"));

      DropItemprefab = (GameObject)Resources.Load ("prefab/DropItem");
    }

    public static ItemType ReturnItemType(int CheckID){
      ItemName itemname = ItemList[CheckID];
      Type itemtype = Type.GetType(itemname.ToString());
      Item item = (Item)Activator.CreateInstance(itemtype);
      return item.Type;
    }

    public static string ReturnInfo(int ItemID){
      ItemName itemname = ItemList[ItemID];
      Type itemtype = Type.GetType(itemname.ToString());
      Item item = (Item)Activator.CreateInstance(itemtype);
      return item.Info;
    }
    public static int ReturnPrice(int ItemID){
      ItemName itemname = ItemList[ItemID];
      Type itemtype = Type.GetType(itemname.ToString());
      Item item = (Item)Activator.CreateInstance(itemtype);
      return item.Price;
    }
    public static string ReturnItemName(int ItemID){
      ItemName itemname = ItemList[ItemID];
      Type itemtype = Type.GetType(itemname.ToString());
      Item item = (Item)Activator.CreateInstance(itemtype);
      return item.Name;
    }
    public static Sprite ReturnImage(int ItemID){
      return ItemImageList[ItemID];
    }

    public static void Use(string Name,int ItemID){
      ItemName itemname = ItemList[ItemID];
      Type itemtype = Type.GetType(itemname.ToString());
      UseItem item = (UseItem)Activator.CreateInstance(itemtype);
      item.Use(Name);
    }
    public static void Equip(int ItemID){
      ItemName itemname = ItemList[ItemID];
      Type itemtype = Type.GetType(itemname.ToString());
      EquipItem item = (EquipItem)Activator.CreateInstance(itemtype);
      item.Equip();
    }
    public static void UnEquip(int ItemID){
      ItemName itemname = ItemList[ItemID];
      Type itemtype = Type.GetType(itemname.ToString());
      EquipItem item = (EquipItem)Activator.CreateInstance(itemtype);
      item.UnEquip();
    }

    public static void DropItemMake(int ItemID,float x,float y){
      GameObject DropItem = GameObject.Instantiate(DropItemprefab, new Vector3(x,y,0), Quaternion.identity);
      DropItemObj dropitem = DropItem.GetComponent<DropItemObj>();
      dropitem.SetUp(ItemID,x,y);
    }

}
