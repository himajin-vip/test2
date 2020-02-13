using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour
{
    public string Name{get; private set;}
    public PlayerStatus Status {get; protected set;} = new PlayerStatus();
    public  Equip Equip{get; protected set;}
    private Move move;
    public StatusMoveSpeed MoveSpeed{get; private set;}
    public Direction Direction{get; private set;}
    public Atack Atack{get; private set;}
    public GameObject Weapon{get; protected set;}
    public Charge Charge{get; protected set;}
    public Skill Skill{get; protected set;}
    private Skill normalAtack;
    public Skill ChargeSkill{get; protected set;}
    private bool TalkFlag = false;
    public Npc Npc{get; protected set;}

    public void SetUp(){
      MoveSpeed = new StatusMoveSpeed(3,1);
      Direction = new Direction(this.gameObject.GetComponent<Animator>());
      move = new Move(this.gameObject,Direction);
      Atack = new Atack(this);
      normalAtack = new SwordNomalAtack(this,this.gameObject);
      Skill = normalAtack;
      ChargeSkill = new SwordChargeAtack(this,this.gameObject);
      Charge = this. transform.Find("tame").GetComponent<Charge>();
      Charge.SetUp(this,this.gameObject);
      Weapon = (GameObject)Resources.Load("prefab/Weapon/Sword");
      Equip = new Equip(this);
    }
    ///////Action
    public void Move(int direction){
      if(!Atack.On){
        switch(direction){
          case 0:
            move.Down(MoveSpeed.Value);
          break;
          case 1:
            move.Up(MoveSpeed.Value);
          break;
          case 2:
            move.Right(MoveSpeed.Value);
          break;
          case 3:
            move.Left(MoveSpeed.Value);
          break;
        }
      }
    }
    public void SetChargeSkill(){
      Skill = ChargeSkill;
    }
    public void SetNormalAtack(){
      Skill = normalAtack;
    }
    public void Talk(){
      if(TalkFlag){
        Npc.Talk();
      }
    }
    ///////Item

    public void ItemUse(ItemID itemID){
      if(new InventoryHasCheck().Check(itemID)){
        UseItem UseItem = new GetUseItem().Get(itemID);
        new InventoryReduce().Reduce(itemID,new ItemPeace(1));
        UseItem.Use(Name);
      }
    }
    public void DropGet(DropItemObj dropItemObj){
      ItemID itemid = new ItemID(dropItemObj.ItemId);
      new Inventory().Add(itemid,new ItemPeace(1));
      new ItemGetLog(Name,itemid);
      new PlayAudio().Play(AudioList.ItemGet);
    }

    public Text SetPeaceText(Text Peacetext,ItemID itemID){
      ItemPeace peace = new InventoryGetPeace().Get(itemID);
      Peacetext.text = new FirstintClasstoStringer().Get(peace);
      return Peacetext;
    }
    //////Status
    public void GetExp(int exp){
      new GetExpLog(Name,exp);
      if(Status.Exp.Get(exp)){
        Status.LvUp();
        new LvUpLog(Name);
        FiledText filedText = new FiledText();
        filedText.Make("LVUP",new Color(255,255,0),this.transform);
      }
        AccountData.Save();
    }
    public void SetName(string name){
      Name = name;
    }
    //////衝突判定
    void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.tag == "Item"){
        DropItemObj getItem = collision.gameObject.GetComponent<DropItemObj>();
        getItem.DropEnd();
        DropGet(getItem);
      }
      if(collision.gameObject.tag == "Npc"){
        Npc = collision.GetComponent<Npc>();
        TalkFlag = true;
      }
    }
    void OnTriggerExit2D(Collider2D collision){
      if(collision.gameObject.tag == "Npc"){
        TalkFlag = false;
        collision.GetComponent<Npc>().End();
      }
    }
}
