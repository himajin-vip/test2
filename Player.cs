using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void ItemUse(int ItemID){
      GameObject Item = ItemManager.returnItemObject(ItemID);
      if(InventoryManager.ReturnPieces(ItemID)>0){
        Item.GetComponent<IItem>().ItemUse(this.gameObject);
        InventoryManager.ItemReduce(ItemID);
      }
    }
    void ItemGet(Collider2D collision){
      int getID = collision.gameObject.GetComponent<IItem>().ItemGet();
      Debug.Log("インベントリに追加するよ");
      InventoryManager.ItemGet(getID);
      collision.gameObject.GetComponent<IItem>().DropEnd();
    }
    void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.tag == "Item"){
        ItemGet(collision);
      }
    }
}
