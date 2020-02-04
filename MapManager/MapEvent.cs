using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapEvent : MonoBehaviour
{
  public int EventNo;
  void OnTriggerEnter2D(Collider2D collision){
    if(collision.gameObject.GetComponent<PlayerObj>()){
      MapManager.MapEvent(EventNo);
    }
  }
}
