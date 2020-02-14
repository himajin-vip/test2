
public class InventoryAdd : InventoryControler
{
    public void Add(ItemBag itemBag){
        ItemID itemID = itemBag.GetID();
        ItemType itemType = new GetItemType().Get(itemID);
        inventoryList[itemType].Add(itemBag);
    }
}
