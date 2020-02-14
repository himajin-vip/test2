using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Indexof_Inventory
{
   public int ItemBagGet(List<ItemBag> inventory ,ItemBag itembag){
       List<int> list = new Get_IntIDList_Inventory().Get(inventory);
       int intID = new Get_IntID_ItemBag().Get(itembag);
       return list.IndexOf(intID);
   }
      public int ItemIDGet(List<ItemBag> inventory ,ItemID itemID){
       List<int> list = new Get_IntIDList_Inventory().Get(inventory);
       int intID = new Firstint_to_Int().Get(itemID);
       return list.IndexOf(intID);
   }
}
