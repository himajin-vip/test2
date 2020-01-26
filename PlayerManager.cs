using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerManager
{
  public static Player Player;

  public static void SetUp(string Job){
    GameObject obj = (GameObject)Resources.Load("Player/"+Job);
    GameObject obj2 = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
    Player = obj2.GetComponent<Player>();
    Player.SetUp();
  }
  public static void PlayerMove(int direction){
    Player.Move(direction);
  }
  public static void PlayerDeathCheck(){
    Player.Death();
  }
}
