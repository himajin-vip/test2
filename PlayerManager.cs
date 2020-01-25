using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerManager
{
  public static GameObject Player;

  public static void SetUp(string Job){
    GameObject obj = (GameObject)Resources.Load("Player/"+Job);
    Player = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
    Player.GetComponent<Player>().PosX = 0;
    Player.GetComponent<Player>().PosY = 0;
    Player.GetComponent<Player>().SetMyWeapon();
    Player.GetComponent<Player>().WeaponEqipment(1);
  }
}
