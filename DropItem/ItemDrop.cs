using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop
{
    private static GameObject DropItemprefab;

    public static void SetUp(){
        // DropItemprefab = (GameObject)Resources.Load ("prefab/DropItem");
    }
    public ItemDrop(List<DropItemData> DropItemList,Transform transform){
        // foreach(DropItemData DropItemData in DropItemList){
        //     DropItemData.DropCheck(DropItemData,transform,DropItemprefab);
        // }
    }
}
