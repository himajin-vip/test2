
public class ItemBag
{
    private ItemID itemID;
    private ItemPeace itemPeace;

    public ItemBag(ItemID itemid ,ItemPeace itempeace){
        itemID = itemid;
        itemPeace = itempeace;
    }
    public ItemID GetID(){
        return itemID;
    }
    public ItemPeace GetPeace(){
        return itemPeace;
    }
}
