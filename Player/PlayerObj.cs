using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObj : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.tag == "Item"){
        InventoryManager.ItemGet(collision);
        AudioManager.AudioON(7);
      }
      if(collision.gameObject.tag == "Npc"){
        GameManager.Player.TouchNpc(collision.GetComponent<Npc>());
      }
    }

    void OnTriggerExit2D(Collider2D collision){
      if(collision.gameObject.tag == "Npc"){
        GameManager.Player.ByeNpc();
        collision.GetComponent<Npc>().End();
      }
    }
}
