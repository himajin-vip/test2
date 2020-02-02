using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerManager
{
  private static Player Player;
  private static Animator PlayerAnimator;
  private static bool PlayerAtackOn;
  public  static bool AtackKeyPush = false;

  public static void SetUp(string Job){
    PlayerAtackOn = false;
    AtackKeyPush = false;
    GameObject obj = (GameObject)Resources.Load("Player/"+Job);
    GameObject obj2 = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
    Player = obj2.GetComponent<Player>();
    PlayerAnimator = Player.GetComponent<Animator>();
    Player.SetUp();
  }
  public static void DamageHp(int damage){
    int FinalDamage = damage-(Player.Vit+Player.EquipVit);
    Player.CurrentHp -= FinalDamage;
    DamageTextManager.Make(FinalDamage,Player.transform.position.x,Player.transform.position.y,new Color(255,0,0),Player.transform);
    LogManager.MakeDamageLog(Player.Name,FinalDamage);
  }
  public static void RecoveryHp(int recovery){
    AudioManager.AudioON(6);
    Player.CurrentHp += recovery;
    if(Player.CurrentHp>Player.MaxHp){
      Player.CurrentHp = Player.MaxHp;
    }
    DamageTextManager.Make(recovery,Player.transform.position.x,Player.transform.position.y,new Color(0,255,0),Player.transform);
    EfectManager.efecton("kaihukuefect",Player.transform.position.x,Player.transform.position.y,Player.gameObject);
  }

  public static void PlayerMove(int direction){
    if(!PlayerAtackOn){
      switch(direction){
        case 0:
          Player.transform.Translate (0,-Player.MoveSpeed,0);
          DirectionChenge(direction);
        break;
        case 1:
          Player.transform.Translate (0,Player.MoveSpeed,0);
          DirectionChenge(direction);
        break;
        case 2:
          Player.transform.Translate (Player.MoveSpeed,0,0);
          DirectionChenge(direction);
        break;
        case 3:
          Player.transform.Translate (-Player.MoveSpeed,0,0);
          DirectionChenge(direction);
        break;
      }
    }
  }

  public　static void DirectionChenge(int direction){
    switch(direction){
      case 0:
        PlayerAnimator.SetInteger("move_direction", 0);
        Player.Direction = 0;
      break;
      case 1:
        PlayerAnimator.SetInteger("move_direction", 1);
        Player.Direction = 1;
      break;
      case 2:
        PlayerAnimator.SetInteger("move_direction", 2);
        Player.Direction = 2;
      break;
      case 3:
        PlayerAnimator.SetInteger("move_direction", 3);
        Player.Direction = 3;
      break;
    }
  }

  public static void ItemUse(int ItemID){
    UseItem Item = ItemManager.returnUseItem(ItemID);
    if(InventoryManager.ReturnPieces(ItemID)>0){
      Item.ItemUse(Player.Name);
      InventoryManager.ItemReduce(ItemID);
    }
  }


  public static void AtackKeyDown(){
    if(!PlayerAtackOn&&!AtackKeyPush){
      Player.ChargeStart();
      AtackKeyPush = true;
    }
  }

  public static void AtackKeyUp(){
    if(!PlayerAtackOn){
      PlayerAtackOn = true;
      Player.MoveSpeed = Player.NomalMoveSpeed;
      Player.Atack();
    }
    AtackKeyPush = false;

  }
  public static void AtackOff(){
    PlayerAtackOn = false;
  }

  public static void AtackDamageCheck(Dictionary<int,Enemy> EnemyList){
    Player.AtackDamageCheck(EnemyList);
  }


  public static void PlayerDeathCheck(){
    if(Player.CurrentHp<=0){
      Player.ChargeEnd();
      GameManager.StateSet("End");
    }
  }
  public static string ReturnName(){
    return Player.Name;
  }
  public static int ReturnLv(){
    return Player.Lv;
  }
  public static int ReturnMaxHp(){
    return Player.MaxHp;
  }
  public static int ReturnCurrentHp(){
    return Player.CurrentHp;
  }
  public static int ReturnMaxMp(){
    return Player.MaxMp;
  }
  public static int ReturnCurrentMp(){
    return Player.CurrentMp;
  }
  public static int ReturnStr(){
    return Player.Str;
  }
  public static int ReturnVit(){
    return Player.Vit;
  }
  public static int ReturnDex(){
    return Player.Dex;
  }
  public static int ReturnInt(){
    return Player.Int;
  }
  public static int ReturnNextExp(){
    return Player.NextExp;
  }
  public static int ReturnCurrentExp(){
    return Player.CurrentExp;
  }
  public static Vector3 ReturnPosition(){
    return Player.transform.position;
  }
  public static int ReturnDirection(){
    return Player.Direction;
  }
  public static bool ReturnFullCharge(){
    return Player.FullCharge;
  }
  public static GameObject ReturnWeapon(){
    return Player.Weapon;
  }
  public static GameObject ReturnPlayerObject(){
    return Player.gameObject;
  }
  public static int ReturnFinalDamage(){
    int Damage1 = Random.Range(0,7);
    if(Damage1 == 6){
      Damage1 += Random.Range(0,7);
    }

    return Damage1+Player.Str+Player.EquipStr;
  }
  static public void WeaponEquip(int ItemID){
      WeaponItem Item = ItemManager.returnWeaponItem(ItemID);
      Player.EquipWeapon = ItemID;
      Item.Equip();
  }
  static public void WeaponUnEquip(int ItemID){
      WeaponItem Item = ItemManager.returnWeaponItem(ItemID);
      Item.UnEquip();
  }
  static public int ReturnEquipWeapon(){
    return Player.EquipWeapon;
  }
  static public void HeadEquip(int ItemID){
      HeadItem Item = ItemManager.returnHeadItem(ItemID);
      Player.EquipHead = ItemID;
      Item.Equip();
  }
  static public void HeadUnEquip(int ItemID){
      HeadItem Item = ItemManager.returnHeadItem(ItemID);
      Item.UnEquip();
  }
  static public int ReturnEquipHead(){
    return Player.EquipHead;
  }
  static public void BodyEquip(int ItemID){
      BodyItem Item = ItemManager.returnBodyItem(ItemID);
      Player.EquipBody = ItemID;
      Item.Equip();
  }
  static public void BodyUnEquip(int ItemID){
      BodyItem Item = ItemManager.returnBodyItem(ItemID);
      Item.UnEquip();
  }
  static public int ReturnEquipBody(){
    return Player.EquipBody;
  }
  static public void HandEquip(int ItemID){
      HandItem Item = ItemManager.returnHandItem(ItemID);
      Player.EquipHand = ItemID;
      Item.Equip();
  }
  static public void HandUnEquip(int ItemID){
      HandItem Item = ItemManager.returnHandItem(ItemID);
      Item.UnEquip();
  }
  static public int ReturnEquipHand(){
    return Player.EquipHand;
  }
  static public void FootEquip(int ItemID){
      FootItem Item = ItemManager.returnFootItem(ItemID);
      Player.EquipFoot = ItemID;
      Item.Equip();
  }
  static public void FootUnEquip(int ItemID){
      FootItem Item = ItemManager.returnFootItem(ItemID);
      Item.UnEquip();
  }
  static public int ReturnEquipFoot(){
    return Player.EquipFoot;
  }
  static public void AccessoryEquip(int ItemID){
      AccessoryItem Item = ItemManager.returnAccessoryItem(ItemID);
      Player.EquipAccessory = ItemID;
      Item.Equip();
  }
  static public void AccessoryUnEquip(int ItemID){
      AccessoryItem Item = ItemManager.returnAccessoryItem(ItemID);
      Item.UnEquip();
  }
  static public int ReturnEquipAccessory(){
    return Player.EquipAccessory;
  }

  public static void SetEquipStr(int str){
    Player.EquipStr+=str;
  }
  public static void SetEquipVit(int vit){
    Player.EquipVit+=vit;
  }
  public static void SetEquipDex(int dex){
    Player.EquipDex+=dex;
  }
  public static void SetEquipInt(int Int){
    Player.EquipInt+=Int;
  }

}
