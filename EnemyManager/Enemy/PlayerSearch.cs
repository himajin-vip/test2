using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSearch : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D collision){//プレイヤーを発見したらMoveStatusを変更
      if(collision.gameObject.GetComponent<PlayerObj>()){
        transform.root.gameObject.GetComponent<Enemy>().MoveStatus = 1;
      }
  }
}
