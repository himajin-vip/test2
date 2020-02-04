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
    if(!DataManager.NewGame){
      Player.LoadStatus(DataManager.LoadData);
      InventoryManager.InventoryLoad(DataManager.LoadData);
    }else{
      Player.NewGame(DataManager.Name);
    }
  }

  public static void PlayerDeathCheck(){
    if(Player.Hp.currentValue<=0){
      Player.Hp.Reset();
      DataManager.Save();
      GameManager.StateSet("End");
    }
  }


}
