using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerManager
{
  public static Player Player{get; private set;} = new Player();

  public static void SetUp(){
    GameObject obj = (GameObject)Resources.Load("Player/Fighter");
    GameObject obj2 = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
    Player.SetObjecct(obj2,obj2.GetComponent<Animator>());
  }



  public static void GetExp(int exp){
    // Exp.Get(exp);
    // LogManager.GetExp(Name.Value,exp);
    // if(Exp.currentValue >= Exp.maxValue){
    //   LvUp();
    // }
    // DataManager.Save();
  }

  public static void LvUp(){
  }

  public static void ItemGet(Collider2D collision){
    DropItem getItem = collision.gameObject.GetComponent<DropItem>();
    InventoryManager.ItemGet(getItem.ItemId);
    LogManager.MakeItemGetLog(Player.Name.Value,getItem.ItemId);
    getItem.DropEnd();
  }


  public static void ItemUse(int ItemID){
    UseItem Item = ItemManager.returnUseItem(ItemID);
    if(InventoryManager.ReturnPieces(ItemID)>0){
      Item.ItemUse(Player.Name.Value);
      InventoryManager.ItemReduce(ItemID);
    }
  }




  public static void AtackDamageCheck(Dictionary<int,Enemy> EnemyList){
    Player.AtackDamageCheck(EnemyList);
  }


  public static void PlayerDeathCheck(){
    if(Player.Hp.currentValue<=0){
      //Player.ChargeEnd();
      Player.Hp.Reset();
      DataManager.Save();
      GameManager.StateSet("End");
    }
  }


  public static int ReturnFinalDamage(){
    int Damage = 0;
    int DamageDice1 = 0;
    int DamageDice2 = 0;
    int ExDamage = (Player.Str.Value+Player.Equip.Str)/10;
    for(int i = 0; i <= 0+ExDamage ; i++){
      DamageDice1 = Random.Range(0,7);
      DamageDice2 = Random.Range(0,7);
      if(DamageDice1+DamageDice2 == 12){
        i--;
      }
      Damage += (DamageDice1+DamageDice2)/2;
    }

    return Damage;
  }
}
