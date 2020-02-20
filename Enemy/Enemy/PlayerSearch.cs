using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerpSearch : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D collision){//プレイヤーを発見したらMoveStatusを変更
      if(collision.gameObject.GetComponent<Player>()){
        Enemy enemy = transform.root.gameObject.GetComponent<Enemy>();

      }
  }
}
