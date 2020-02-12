using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData
{
  public string Name;
  public int Lv;
  public int MaxHp;
  public int CurrentHp;
  public int MaxMp;
  public int CurrentMp;
  public int Str;
  public int Vit;
  public int Dex;
  public int Int;
  public int NextExp;
  public int CurrentExp;
  public int EquipWeapon;
  public int EquipHead;
  public int EquipBody;
  public int EquipHand;
  public int EquipFoot;
  public int EquipAccessory;
  public List<int> UseItemList  = new List<int>();
  public List<int> UseItemNumberList  = new List<int>();
  public List<int> WeaponItemList  = new List<int>();
  public List<int> WeaponItemNumberList  = new List<int>();
  public List<int> HeadItemList  = new List<int>();
  public List<int> HeadItemNumberList  = new List<int>();
  public List<int> BodyItemList  = new List<int>();
  public List<int> BodyItemNumberList  = new List<int>();
  public List<int> HandItemList  = new List<int>();
  public List<int> HandItemNumberList  = new List<int>();
  public List<int> FootItemList  = new List<int>();
  public List<int> FootItemNumberList  = new List<int>();
  public List<int> AccesuryItemList  = new List<int>();
  public List<int> AccesuryItemNumberList = new List<int>();

  public void Update(Player player){
     Name = player.Name;
     Lv = player.Status.Lv;
     MaxHp = player.Status.Hp.maxValue;
     CurrentHp = player.Status.Hp.currentValue;
     MaxMp = player.Status.Mp.maxValue;
     CurrentMp = player.Status.Mp.currentValue;
     Str = player.Status.Str.NomalValue;
     Vit = player.Status.Vit.NomalValue;
     Dex = player.Status.Dex.NomalValue;
     Int = player.Status.Int.NomalValue;
     NextExp = player.Status.Exp.maxValue;
     CurrentExp = player.Status.Exp.currentValue;
     EquipWeapon = player.Equip.Parts[ItemType.Weapon].ItemId;
     EquipHead = player.Equip.Parts[ItemType.Head].ItemId;
     EquipBody = player.Equip.Parts[ItemType.Body].ItemId;
     EquipHand = player.Equip.Parts[ItemType.Hand].ItemId;
     EquipFoot = player.Equip.Parts[ItemType.Foot].ItemId;
     EquipAccessory = player.Equip.Parts[ItemType.Accessory].ItemId;

     UseItemList = InventoryManager.ReturnInventoryList(ItemType.Use);
     UseItemNumberList = InventoryManager.ReturnInventoryNumberList(ItemType.Use);

     WeaponItemList = InventoryManager.ReturnInventoryList(ItemType.Weapon);
     WeaponItemNumberList = InventoryManager.ReturnInventoryNumberList(ItemType.Weapon);

     HeadItemList = InventoryManager.ReturnInventoryList(ItemType.Head);
     HeadItemNumberList = InventoryManager.ReturnInventoryNumberList(ItemType.Head);

     BodyItemList = InventoryManager.ReturnInventoryList(ItemType.Body);
     BodyItemNumberList = InventoryManager.ReturnInventoryNumberList(ItemType.Body);

     HandItemList = InventoryManager.ReturnInventoryList(ItemType.Hand);
     HandItemNumberList = InventoryManager.ReturnInventoryNumberList(ItemType.Hand);

     FootItemList = InventoryManager.ReturnInventoryList(ItemType.Foot);
     FootItemNumberList = InventoryManager.ReturnInventoryNumberList(ItemType.Foot);

     AccesuryItemList = InventoryManager.ReturnInventoryList(ItemType.Accessory);
     AccesuryItemNumberList = InventoryManager.ReturnInventoryNumberList(ItemType.Accessory);

  }
}
