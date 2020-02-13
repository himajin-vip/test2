using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DropItemData
{
   private ItemID itemID;
   private ItemPeace itemPeace;
   private DropRate dropRate;

   public DropItemData(ItemID ItemID ,ItemPeace ItemPeace,DropRate DropRate){
       itemID = ItemID;
       itemPeace = ItemPeace;
       dropRate = DropRate;
   }
    public void DropCheck(DropItemData dropItemData,Transform transform,GameObject DropItemprefab){
        if(0 == Random.Range(0,dropRate.GetValue())){
            GameObject dropItemObj = GameObject.Instantiate(DropItemprefab, new Vector3(transform.position.x,transform.position.y,0), Quaternion.identity);
            DropItemObj dropitem = dropItemObj.GetComponent<DropItemObj>();
            dropitem.SetUp(itemID,itemPeace);
        }
    }
}
