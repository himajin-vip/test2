using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player
{
  public GameObject GameObject{get; private set;}
  public Animator Animator{get; private set;}

  public Name Name{get; private set;}
  public Lv Lv{get; private set;}
  public Hp Hp{get; private set;}
  public Mp Mp{get; private set;}
  public Str Str{get; private set;}
  public Vit Vit{get; private set;}
  public Dex Dex{get; private set;}
  public Int Int{get; private set;}
  public Exp Exp{get; private set;}

  public Move Move{get; private set;} = new Move();
  public MoveSpeed MoveSpeed{get; private set;}
  public Direction Direction{get; private set;}

  public  Equip Equip{get; private set;}
  ///////チャージ////////
  public Charge Charge{get; private set;}

  //////使用武器/////////
  public GameObject Weapon{get; private set;}

  ///////スキル//////////
  public Skill Skill{get; private set;}
  public Skill NormalAtack{get; private set;}
  public Skill ChargeSkill{get; private set;}

  ///////攻撃////////////
  public Atack Atack{get; private set;} = new Atack();


  public void ItemUse(int ItemID){
    UseItem Item = ItemManager.returnUseItem(ItemID);
    if(InventoryManager.ReturnPieces(ItemID)>0){
      Item.ItemUse(Name.Value);
      InventoryManager.ItemReduce(ItemID);
    }
  }

  public void LoadStatus(SaveData SaveData){

    Name = new Name(SaveData.Name);
    Lv = new Lv(SaveData.Lv);
    Hp = new Hp(SaveData.MaxHp,SaveData.CurrentHp);
    Mp = new Mp(SaveData.MaxMp,SaveData.CurrentMp);
    Str = new Str(SaveData.Str);
    Vit = new Vit(SaveData.Vit);
    Dex = new Dex(SaveData.Dex);
    Int = new Int(SaveData.Int);
    Exp = new Exp(SaveData.NextExp,SaveData.CurrentExp);
    MoveSpeed = new MoveSpeed(3,1);

    Direction = new Direction(Animator);

    ChargeSkill = new SwordChargeAtack();
    NormalAtack = new SwordNomalAtack();
    Skill = NormalAtack;
    Charge = GameObject.transform.Find("tame").GetComponent<Charge>();
    Weapon = (GameObject)Resources.Load("prefab/Weapon/Sword");
    Equip = new Equip();

    if(Equip.Weapon.ItemId != 9999){
      Equip.Weapon.Set(SaveData.EquipWeapon);
      WeaponItem Item = ItemManager.returnWeaponItem(Equip.Weapon.ItemId);
      Item.Equip();
    }
    if(Equip.Head.ItemId != 9999){
      Equip.Head.Set(SaveData.EquipHead);
      HeadItem Item = ItemManager.returnHeadItem(Equip.Head.ItemId);
      Item.Equip();
    }
    if(Equip.Body.ItemId != 9999){
      Equip.Body.Set(SaveData.EquipBody);
      BodyItem Item = ItemManager.returnBodyItem(Equip.Body.ItemId);
      Item.Equip();
    }
    if(Equip.Hand.ItemId != 9999){
      Equip.Hand.Set(SaveData.EquipHand);
      HandItem Item = ItemManager.returnHandItem(Equip.Hand.ItemId);
      Item.Equip();
    }

    if(Equip.Foot.ItemId != 9999){
      Equip.Foot.Set(SaveData.EquipFoot);
      FootItem Item = ItemManager.returnFootItem(Equip.Foot.ItemId);
      Item.Equip();
    }

    if(Equip.Accessory.ItemId  != 9999){
      Equip.Accessory.Set(SaveData.EquipAccessory);
      AccessoryItem Item = ItemManager.returnAccessoryItem(Equip.Accessory.ItemId);
      Item.Equip();
    }
  }

  public void NewGame(string name){
    Name = new Name(name);
    Lv = new Lv(1);
    Hp = new Hp(50,50);
    Mp = new Mp(10,10);
    Str = new Str(1);
    Vit = new Vit(1);
    Dex = new Dex(1);
    Int = new Int(1);
    Exp = new Exp(10,0);
    MoveSpeed = new MoveSpeed(3,1);

    Equip = new Equip();

    Direction = new Direction(Animator);

    Weapon = (GameObject)Resources.Load("prefab/Weapon/Sword");

    ChargeSkill = new SwordChargeAtack();
    NormalAtack = new SwordNomalAtack();
    Skill = NormalAtack;
    Charge = GameObject.transform.Find("tame").GetComponent<Charge>();
  }
  public void LvUp(){
    Lv.LvUp();
    Hp.LvUp(10);
    Mp.LvUp(5);
    Str.LvUp(5);
    Vit.LvUp(5);
    Dex.LvUp(3);
    Int.LvUp(1);
    DataManager.Save();
  }

  public void SetObjecct(GameObject obj ,Animator ani){
    GameObject = obj;
    Animator = ani;
  }

  public void SetChargeSkill(){
    Skill = ChargeSkill;
  }
  public void SetNormalAtack(){
    Skill = NormalAtack;
  }


}
