using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBagConvertor
{
    public List<IData> toIDatas(List<ItemBag> itemBags){
        List<IData> IDatas = new List<IData>(itemBags);
        return IDatas;
    }
}
