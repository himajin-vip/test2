using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class ItemManager
{
  private static Dictionary<int,Sprite> ItemImageList = new Dictionary<int,Sprite>();
  private static Dictionary<int,ItemNames> ItemList = new Dictionary<int, ItemNames>();
  private static GameObject DropItemprefab;



    public ItemManager(){//Excelとかで読み込めないかな
      ItemImageList.Clear();
      ItemList.Clear();
      ItemList.Add(0,ItemNames.Potion);
      ItemList.Add(1,ItemNames.HiPotion);
      ItemList.Add(100,ItemNames.IronSword);
      ItemList.Add(200,ItemNames.LeatherCap);
      ItemList.Add(300,ItemNames.LeatherBody);
      ItemList.Add(400,ItemNames.LeatherHand);
      ItemList.Add(500,ItemNames.LeatherFoot);

    }

    public void SetUp(){
      ItemImageList.Add(0,Resources.Load<Sprite>("ItemImage/Potion"));
      ItemImageList.Add(1,Resources.Load<Sprite>("ItemImage/HiPotion"));

      DropItemprefab = (GameObject)Resources.Load ("prefab/DropItem");
    }
    public static void Equip(int ItemID,Player player){
      ItemNames itemname = ItemList[ItemID];
      Type itemtype = Type.GetType(itemname.ToString());
      EquipItem item = (EquipItem)Activator.CreateInstance(itemtype);
      item.Equip(player);
    }
    public static void UnEquip(int ItemID,Player player){
      ItemNames itemname = ItemList[ItemID];
      Type itemtype = Type.GetType(itemname.ToString());
      EquipItem item = (EquipItem)Activator.CreateInstance(itemtype);
      item.UnEquip(player);
    }


}
