using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_IntID_ItemBag
{
   public int Get(ItemBag itembag){
       ItemID itemID = itembag.GetID();
       return new Firstint_to_Int().Get(itemID);
   }
}
