using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Name{get; private set;}
    public PlayerStatus Status{get; protected set;}
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

    public Player(){
      MoveSpeed = new StatusMoveSpeed(3,1);
      Direction = new Direction(this.GetComponent<Animator>());
      move = new Move(this.gameObject,MoveSpeed.Value,Direction);
      Atack = new Atack(this);
      Charge = this.transform.Find("tame").GetComponent<Charge>();
      Weapon = (GameObject)Resources.Load("prefab/Weapon/Sword");
    }
    public void Move(int direction){
      if(!Atack.On){
        switch(direction){
          case 0:
            move.Down();
          break;
          case 1:
            move.Up();
          break;
          case 2:
            move.Right();
          break;
          case 3:
            move.Left();
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

    public void ItemUse(int ItemID){
      if(InventoryManager.ReturnPieces(ItemID)>0){
        ItemManager.Use(Name,ItemID);
        InventoryManager.ItemReduce(ItemID);
      }
    }
    public void GetExp(int exp){
      new GetExpLog(Name,exp);
      if(Status.Exp.Get(exp)){
        Status.LvUp();
        new LvUpLog(Name);
        FiledText filedText = new FiledText();
        filedText.Make("LVUP",new Color(255,255,0),this.transform);
      }
        GameManager.AccountData.Save();
    }
    public void SetName(string name){
      Name = name;
    }

    void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.tag == "Item"){
        DropItemObj getItem = collision.gameObject.GetComponent<DropItemObj>();
        getItem.DropEnd();
        InventoryManager.ItemGet(getItem);
        new ItemGetLog(Name,getItem.ItemId);
        AudioManager.AudioON(7);
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
