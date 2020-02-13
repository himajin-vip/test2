
public class InventoryReduce : InventoryControler
{
    public void Reduce(ItemID itemID,ItemPeace itemPeace){
        ItemType itemType = new GetItemType().Get(itemID);
        inventoryList[itemType].Reduce(itemID,itemPeace);
    }
}
