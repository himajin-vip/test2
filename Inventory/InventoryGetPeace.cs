
public class InventoryGetPeace : InventoryControler
{
    public ItemPeace Get(ItemID itemID){
        ItemType itemType = new GetItemType().Get(itemID);
        return inventoryList[itemType].GetPeace(itemID);
    }
}
