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
     Name = PlayerManager.ReturnName();
     Lv = PlayerManager.ReturnLv();
     MaxHp = PlayerManager.ReturnMaxHp();
     CurrentHp = PlayerManager.ReturnCurrentHp();
     MaxMp = PlayerManager.ReturnMaxMp();
     CurrentMp = PlayerManager.ReturnCurrentMp();
     Str = PlayerManager.ReturnStr();
     Vit = PlayerManager.ReturnVit();
     Dex = PlayerManager.ReturnDex();
     Int = PlayerManager.ReturnInt();
     NextExp = PlayerManager.ReturnNextExp();
     CurrentExp = PlayerManager.ReturnCurrentExp();
     EquipWeapon = PlayerManager.ReturnEquipWeapon();
     EquipHead = PlayerManager.ReturnEquipHead();
     EquipBody = PlayerManager.ReturnEquipBody();
     EquipHand = PlayerManager.ReturnEquipHand();
     EquipFoot = PlayerManager.ReturnEquipFoot();
     EquipAccessory = PlayerManager.ReturnEquipAccessory();

     UseItemList = InventoryManager.ReturnInventoryList("UseItem");
     UseItemNumberList = InventoryManager.ReturnInventoryNumberList("UseItem");

     WeaponItemList = InventoryManager.ReturnInventoryList("WeaponItem");
     WeaponItemNumberList = InventoryManager.ReturnInventoryNumberList("WeaponItem");

     HeadItemList = InventoryManager.ReturnInventoryList("HeadItem");
     HeadItemNumberList = InventoryManager.ReturnInventoryNumberList("HeadItem");

     BodyItemList = InventoryManager.ReturnInventoryList("BodyItem");
     BodyItemNumberList = InventoryManager.ReturnInventoryNumberList("BodyItem");

     HandItemList = InventoryManager.ReturnInventoryList("HandItem");
     HandItemNumberList = InventoryManager.ReturnInventoryNumberList("HandItem");

     FootItemList = InventoryManager.ReturnInventoryList("FootItem");
     FootItemNumberList = InventoryManager.ReturnInventoryNumberList("FootItem");

     AccesuryItemList = InventoryManager.ReturnInventoryList("AccesuryItem");
     AccesuryItemNumberList = InventoryManager.ReturnInventoryNumberList("AccesuryItem");

  }
}
