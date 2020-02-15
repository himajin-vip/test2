using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public interface InventoryCounter
{
     void Add(ItemBag itemBag);
     void Reduce(ItemID itemId,ItemPeace itemPeace);
     Value GetValue(ItemID itemID);
     void Load(List<List<ItemBag>> InventorysData);
     List<List<ItemBag>> GetInventorysDatas();

}
