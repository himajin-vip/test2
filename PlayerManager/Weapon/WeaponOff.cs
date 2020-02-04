using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponOff : MonoBehaviour
{
  public  void OnEnd(){
     Destroy (this.gameObject);
    PlayerManager.Player.AtackOff();
    }
}
