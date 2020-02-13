using System.Collections.Generic;


public class InventoryManager
{
    private InventoryList inventoryList = new InventoryList();
    public void Add(ItemID itemID , ItemPeace itemPeace){
      inventoryList.Add(itemID,itemPeace);
      AccountData.Save();
    }

    public ItemPeace GetPieces(ItemID itemID){
        return inventoryList.GetPeace(itemID);
    }
    public bool HasCheck(ItemID itemID){
      if(GetPieces(itemID).GetValue() > 0){
        return true;
      }
      return false;
    }
    public void Reduce(ItemID itemID,ItemPeace itemPeace){
      ItemType ItemType = new GetItemType().Get(itemID);
      inventoryList.Reduce(itemID,itemPeace);
      AccountData.Save();
    }

//////////セーブデーター関連
    public List<int> GetIdList(ItemType ItemType){
        return inventoryList.GetIdList(ItemType);
    }
    public List<int> GetPeaceList(ItemType ItemType){
        return inventoryList.GetPeaceList(ItemType);
    }

    public void InventoryLoad(SaveData SaveData){
      inventoryList.Load(SaveData.UseItemList,SaveData.UseItemNumberList);
      inventoryList.Load(SaveData.WeaponItemList,SaveData.WeaponItemNumberList);
      inventoryList.Load(SaveData.HeadItemList,SaveData.HeadItemNumberList);
      inventoryList.Load(SaveData.BodyItemList,SaveData.BodyItemNumberList);
      inventoryList.Load(SaveData.HandItemList,SaveData.HandItemNumberList);
      inventoryList.Load(SaveData.FootItemList,SaveData.FootItemNumberList);
      inventoryList.Load(SaveData.AccesuryItemList,SaveData.AccesuryItemNumberList);
    }
}
