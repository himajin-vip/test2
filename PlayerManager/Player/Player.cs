using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player
{
  public GameObject GameObject{get; private set;}
  public Animator Animator{get; private set;}

  public  Name Name{get; private set;}
  public  Lv Lv{get; private set;}
  public  Hp Hp{get; private set;}
  public  Mp Mp{get; private set;}
  public  Str Str{get; private set;}
  public  Vit Vit{get; private set;}
  public  Dex Dex{get; private set;}
  public  Int Int{get; private set;}
  public  Exp Exp{get; private set;}
  public  MoveSpeed MoveSpeed{get; private set;}

  public int Direction{get; private set;} = 0;

  public  Equip Equip{get; private set;}
  ///////チャージ////////
  Charge Charge;
  public float ChargeTime = 2f;

  //////使用武器/////////
  public GameObject Weapon{get; private set;}

  ///////スキル//////////
  public Skill Skill;
  public Skill NormalAtack;
  public Skill ChargeSkill;

  ///////いろいろ///////
  private bool AtackOn = false;
  private  bool AtackKeyPush = false;


  public void MoveDown(){
    if(!AtackOn){
      GameObject.transform.Translate (0,-PlayerManager.Player.MoveSpeed.Value,0);
      DirectionDown();
    }
  }
  public void MoveUp(){
    if(!AtackOn){
      GameObject.transform.Translate (0,PlayerManager.Player.MoveSpeed.Value,0);
      DirectionUp();
    }
  }
  public void MoveRight(){
    if(!AtackOn){
      GameObject.transform.Translate (PlayerManager.Player.MoveSpeed.Value,0,0);
      DirectionRight();
    }
  }
  public void MoveLeft(){
    if(!AtackOn){
      GameObject.transform.Translate (-PlayerManager.Player.MoveSpeed.Value,0,0);
      DirectionLeft();
    }
  }

  public void DirectionDown(){
    Animator.SetInteger("move_direction", 0);
    Direction = 0;
  }
  public void DirectionUp(){
    Animator.SetInteger("move_direction", 1);
    Direction = 1;
  }
  public void DirectionRight(){
    Animator.SetInteger("move_direction", 2);
    Direction = 2;
  }
  public void DirectionLeft(){
    Animator.SetInteger("move_direction", 3);
    Direction = 3;
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

    ChargeSkill = new SwordChargeAtack();
    NormalAtack = new SwordNomalAtack();
    Skill = NormalAtack;
    Charge = GameObject.transform.Find("tame").GetComponent<Charge>();

    Equip = new Equip();

    Equip.Weapon.Set(SaveData.EquipWeapon);
    if(!(Equip.Weapon.ItemId == 9999)){
      WeaponItem Item = ItemManager.returnWeaponItem(Equip.Weapon.ItemId);
      Item.Equip();
    }
    Equip.Head.Set(SaveData.EquipHead);
    if(!(Equip.Head.ItemId == 9999)){
      HeadItem Item = ItemManager.returnHeadItem(Equip.Head.ItemId);
      Item.Equip();
    }
    Equip.Body.Set(SaveData.EquipBody);
    if(!(Equip.Body.ItemId == 9999)){
      BodyItem Item = ItemManager.returnBodyItem(Equip.Body.ItemId);
      Item.Equip();
    }
    Equip.Hand.Set(SaveData.EquipHand);
    if(!(Equip.Hand.ItemId == 9999)){
      HandItem Item = ItemManager.returnHandItem(Equip.Hand.ItemId);
      Item.Equip();
    }

    Equip.Foot.Set(SaveData.EquipFoot);
    if(!(Equip.Foot.ItemId == 9999)){
      FootItem Item = ItemManager.returnFootItem(Equip.Foot.ItemId);
      Item.Equip();
    }

    Equip.Accessory.Set(SaveData.EquipAccessory);
    if(!(Equip.Accessory.ItemId  == 9999)){
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
    Exp = new Exp(50,0);
    MoveSpeed = new MoveSpeed(3,1);

    Equip = new Equip();

    Weapon = (GameObject)Resources.Load("prefab/Weapon/Sword");

    ChargeSkill = new SwordChargeAtack();
    NormalAtack = new SwordNomalAtack();
    Skill = NormalAtack;
    Charge = GameObject.transform.Find("tame").GetComponent<Charge>();

  }

  public void Atack(){
    Charge.Stop();
    Skill.AtackOn();
  }

  public void AtackKeyDown(){
    if(!AtackOn&&!AtackKeyPush){
      Charge.Set();
      AtackKeyPush = true;
    }
  }

  public void AtackKeyUp(){
    if(!AtackOn){
      AtackOn = true;
      MoveSpeed.ReSetSpeed();
      Atack();
    }
    AtackKeyPush = false;

  }
  public void AtackOff(){
    AtackOn = false;
  }

  public void AtackDamageCheck(Dictionary<int,Enemy> EnemyList){
    Skill.Damage(EnemyList);
    SetNormalAtack();
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
