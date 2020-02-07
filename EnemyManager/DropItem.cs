using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem
{
   public int ItemNo{get; private set;}
   public int　DropRate{get; private set;}

   public DropItem(int itemno, int droprate){
       ItemNo = itemno;
       DropRate = droprate;
   }


}
