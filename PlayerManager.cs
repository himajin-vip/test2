using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerManager
{
  public static Player Player;

  public static void SetUp(string Job){
    GameObject obj = (GameObject)Resources.Load("Player/"+Job);
    Player = obj.GetComponent<Player>();
    Player.SetUp();
  }
  public void PlayerMove(){
    
  }
}
