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

  public void LoadStatus(SaveData LoadData){

    Name = new Name(LoadData.Name);
    Lv = new Lv(LoadData.Lv);
    Hp = new Hp(LoadData.MaxHp,LoadData.CurrentHp);
    Mp = new Mp(LoadData.MaxMp,LoadData.CurrentMp);
    Str = new Str(LoadData.Str);
    Vit = new Vit(LoadData.Vit);
    Dex = new Dex(LoadData.Dex);
    Int = new Int(LoadData.Int);
    Exp = new Exp(LoadData.NextExp,LoadData.CurrentExp);
    MoveSpeed = new MoveSpeed(3,1);

    Direction = new Direction(Animator);

    ChargeSkill = new SwordChargeAtack();
    NormalAtack = new SwordNomalAtack();
    Skill = NormalAtack;
    Charge = GameObject.transform.Find("tame").GetComponent<Charge>();
    Weapon = (GameObject)Resources.Load("prefab/Weapon/Sword");
    Equip = new Equip();
    Equip.Weapon(LoadData.EquipWeapon);
    Equip.Head(LoadData.EquipHead);
    Equip.Body(LoadData.EquipBody);
    Equip.Hand(LoadData.EquipHand);
    Equip.Foot(LoadData.EquipFoot);
    Equip.Accessory(LoadData.EquipAccessory);
    
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
