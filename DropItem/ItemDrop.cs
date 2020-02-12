using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop
{
    private static GameObject DropItemprefab;

    public void SetUp(){
        DropItemprefab = (GameObject)Resources.Load ("prefab/DropItem");
    }
    public ItemDrop(List<DropItem> DropItemList,Transform transform){
        foreach(DropItem DropItem in DropItemList){
            if(0 == Random.Range(0,DropItem.DropRate)){
                GameObject dropItemObj = GameObject.Instantiate(DropItemprefab, new Vector3(transform.position.x,transform.position.y,0), Quaternion.identity);
                DropItemObj dropitem = dropItemObj.GetComponent<DropItemObj>();
                dropitem.SetUp(DropItem.ItemNo);
            }
        }
    }
}
