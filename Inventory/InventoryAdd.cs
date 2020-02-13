
public class InventoryAdd : InventoryControler
{
    public void Add(ItemID itemID,ItemPeace itemPeace){
        ItemType itemType = new GetItemType().Get(itemID);
        inventoryList[itemType].Add(itemID,itemPeace);
    }
}
