using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObj : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.tag == "Item"){
        PlayerManager.ItemGet(collision);
        AudioManager.AudioON(7);
      }
    }
}
