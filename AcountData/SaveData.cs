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

  public void Update(Playerp Playerp){
    Name = Playerp.Name;
    Lv = Playerp.Status.Lv;
    MaxHp = Playerp.Status.Hp.maxValue;
    CurrentHp = Playerp.Status.Hp.currentValue;
    MaxMp = Playerp.Status.Mp.maxValue;
    CurrentMp = Playerp.Status.Mp.currentValue;
    Str = Playerp.Status.Str.NomalValue;
    Vit = Playerp.Status.Vit.NomalValue;
    Dex = Playerp.Status.Dex.NomalValue;
    Int = Playerp.Status.Int.NomalValue;
    NextExp = Playerp.Status.Exp.maxValue;
    CurrentExp = Playerp.Status.Exp.currentValue;
    EquipWeapon = Playerp.Equip.Parts[ItemType.Weapon].ItemId;
    EquipHead = Playerp.Equip.Parts[ItemType.Head].ItemId;
    EquipBody = Playerp.Equip.Parts[ItemType.Body].ItemId;
    EquipHand = Playerp.Equip.Parts[ItemType.Hand].ItemId;
    EquipFoot = Playerp.Equip.Parts[ItemType.Foot].ItemId;
    EquipAccessory = Playerp.Equip.Parts[ItemType.Accessory].ItemId;

    // UseItemList = new InventoryGetIDList().Get(ItemType.Use);
    // UseItemNumberList = new InventoryGetPeaceList().Get(ItemType.Use);

    // WeaponItemList = new InventoryGetIDList().Get(ItemType.Weapon);
    // WeaponItemNumberList = new InventoryGetPeaceList().Get(ItemType.Weapon);

    // HeadItemList = new InventoryGetIDList().Get(ItemType.Head);
    // HeadItemNumberList = new InventoryGetPeaceList().Get(ItemType.Head);

    // BodyItemList = new InventoryGetIDList().Get(ItemType.Body);
    // BodyItemNumberList =  new InventoryGetPeaceList().Get(ItemType.Body);

    // HandItemList = new InventoryGetIDList().Get(ItemType.Hand);
    // HandItemNumberList =  new InventoryGetPeaceList().Get(ItemType.Hand);

    // FootItemList = new InventoryGetIDList().Get(ItemType.Foot);
    // FootItemNumberList =  new InventoryGetPeaceList().Get(ItemType.Foot);

    // AccesuryItemList = new InventoryGetIDList().Get(ItemType.Accessory);
    // AccesuryItemNumberList =  new InventoryGetPeaceList().Get(ItemType.Accessory);

  }
}
