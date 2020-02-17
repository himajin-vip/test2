using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPriceDataList
{
    List<ItemPriceData> ItemPriceDatas = new List<ItemPriceData>();

    public ItemPriceDataList(){
        ItemPriceDatas[0]=(new ItemPriceData(new ItemID(0),new ItemPrice(30)));
    }
 
}
