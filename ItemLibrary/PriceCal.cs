using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceCal
{
    public ItemPrice Get(ItemPrice itemPrice, ItemPeace itemPeace){
       return new ItemPrice(itemPrice.GetIntValue()*itemPeace.GetIntValue());
    }
}
