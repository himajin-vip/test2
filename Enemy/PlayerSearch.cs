using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSearch : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.GetComponent<Player>()){
        Enemy enemy = transform.root.gameObject.GetComponent<Enemy>();
        enemy.FindPlayer(collision.gameObject.GetComponent<Player>());
      }
  }
}
