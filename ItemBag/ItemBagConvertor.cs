using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBagConvertor
{
    public List<Data> toDatas(List<ItemBag> itemBags){
        List<Data> Datas = new List<Data>(itemBags);
        return Datas;
    }
}
