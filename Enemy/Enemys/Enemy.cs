using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Charactor
{
  Player Player;
  bool FindMove = false;
  public Enemy(){
    DataCounter.AddCounters(new StatusCounter());
  }

  public void FindPlayer(Player player){
    Player = player;
  }
  public Player GetFindPlayer(){
    return Player;
  }
  public bool FindCheck(){
    if(Player != null&&!FindMove){
      FindMove = true;
      return true;
    }
    return false;
  }
}
