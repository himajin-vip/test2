using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop
{
    public ItemDrop(List<DropItem> DropItemList,Transform transform){
        foreach(DropItem DropItem in DropItemList){
            if(0 == Random.Range(0,DropItem.DropRate)){
                ItemManager.DropItemMake(DropItem.ItemNo,transform.position.x,transform.position.y);
            }
        }
    }
}
