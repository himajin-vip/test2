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

  public void Update(){
     Name = GameManager.Player.Name.Value;
     Lv = GameManager.Player.Lv.Value;
     MaxHp = GameManager.Player.Hp.maxValue;
     CurrentHp = GameManager.Player.Hp.currentValue;
     MaxMp = GameManager.Player.Mp.maxValue;
     CurrentMp = GameManager.Player.Mp.currentValue;
     Str = GameManager.Player.Str.NomalValue;
     Vit = GameManager.Player.Vit.NomalValue;
     Dex = GameManager.Player.Dex.NomalValue;
     Int = GameManager.Player.Int.NomalValue;
     NextExp = GameManager.Player.Exp.maxValue;
     CurrentExp = GameManager.Player.Exp.currentValue;
     EquipWeapon = GameManager.Player.Equip.Parts[ItemType.Weapon].ItemId;
     EquipHead = GameManager.Player.Equip.Parts[ItemType.Head].ItemId;
     EquipBody = GameManager.Player.Equip.Parts[ItemType.Body].ItemId;
     EquipHand = GameManager.Player.Equip.Parts[ItemType.Hand].ItemId;
     EquipFoot = GameManager.Player.Equip.Parts[ItemType.Foot].ItemId;
     EquipAccessory = GameManager.Player.Equip.Parts[ItemType.Accessory].ItemId;

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
