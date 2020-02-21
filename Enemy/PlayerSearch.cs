using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSearch : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.GetComponent<Player>()){
        Enemy enemy = transform.root.gameObject.GetComponent<Enemy>();
        Player player = collision.gameObject.GetComponent<Player>();
        PlayerFindData playerFindData = new PlayerFindData(player,enemy);
        GameManager.SetState(States.PlayerFind,playerFindData);
      }
  }
}
