using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player
{
  public GameObject GameObject{get; protected set;}
  public Animator Animator{get; protected set;}

  public Name Name{get; protected set;}
  public Lv Lv{get; protected set;}
  public Hp Hp{get; protected set;}
  public Mp Mp{get; protected set;}
  public Str Str{get; protected set;}
  public Vit Vit{get; protected set;}
  public Dex Dex{get; protected set;}
  public Int Int{get; protected set;}
  public Exp Exp{get; protected set;}

  public MoveSpeed MoveSpeed{get; protected set;}
  public Direction Direction{get; protected set;}

  public  Equip Equip{get; protected set;}
  ///////チャージ////////
  public Charge Charge{get; protected set;}

  //////使用武器/////////
  public GameObject Weapon{get; protected set;}

  ///////スキル//////////
  public Skill Skill{get; protected set;}
  public Skill NormalAtack{get; protected set;}
  public Skill ChargeSkill{get; protected set;}

  ///////攻撃////////////
  public Atack Atack{get; protected set;}

  //////自動回復//////////
  protected AutoKaihuku AutoKaihuku;

  /////Talk//////////////
  protected bool TalkFlag = false;
  public Npc Npc{get; protected set;}

  public void Talk(){
    if(TalkFlag){
     Npc.Talk();
    }
  }
  public void TouchNpc(Npc npc){
    TalkFlag = true;
    Npc = npc;
  }

  public void ByeNpc(){
    TalkFlag = false;
    Debug.Log("Bye");
  }
  public void ItemUse(int ItemID){
    if(InventoryManager.ReturnPieces(ItemID)>0){
      ItemManager.Use(Name.Value,ItemID);
      InventoryManager.ItemReduce(ItemID);
    }
  }
  public void LvUp(){
    Lv.LvUp();
    Hp.LvUp(50);
    Mp.LvUp(5);
    Str.LvUp(1);
    Vit.LvUp(1);
    Dex.LvUp(1);
    Int.LvUp(1);
    GameManager.AccountData.Save();
  }

  public void SetObjecct(GameObject obj ,Animator ani){
    GameObject = obj;
    Animator = ani;
    Charge = GameObject.transform.Find("tame").GetComponent<Charge>();
    Weapon = (GameObject)Resources.Load("prefab/Weapon/Sword");
    AutoKaihuku = GameObject.transform.Find("kaihuku").GetComponent<AutoKaihuku>();
    AutoKaihuku.Set();
    Direction = new Direction(Animator);
  }

  public void SetChargeSkill(){
    Skill = ChargeSkill;
  }
  public void SetNormalAtack(){
    Skill = NormalAtack;
  }


}
