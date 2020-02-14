using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_ItemPeace_Inventory
{
   public ItemPeace Get(List<ItemBag> inventory ,ItemID itemID){
       if(new HasCheck_Inventory().IDCheck(inventory,itemID)){
            ItemBag itemBag = new Get_ItemBag_Inventory().Get(inventory,itemID);
            return new Copy_ItemPeace().Copy(itemBag.GetPeace());
       }
       return new ItemPeace(0);
   }
}
