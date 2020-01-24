using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
  public static GameObject Player;

  public static void MakePlayer(string Job){
    GameObject obj = (GameObject)Resources.Load("Player/"+Job);
    Player = Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
    Player.GetComponent<Player>().PosX = 0;
    Player.GetComponent<Player>().PosY = 0;
    Player.GetComponent<Player>().SetMyWeapon();
    Player.GetComponent<Player>().WeaponEqipment(1);
  }
}
