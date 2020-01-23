using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
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
      collision.gameObject.GetComponent<ObjectEnd>().end();
    }
    void OnTriggerEnter2D(Collider2D collision){
      if(collision.gameObject.tag == "Item"){
        ItemGet(collision);
      }
    }
}
