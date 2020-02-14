
public class BuyItem
{
    public bool Buy(ItemID itemID, ItemPeace itemPeace){
      ItemPrice itemPrice = new GetItemPrice().Get(itemID,itemPeace);
      Gold gold = new Gold(itemPrice.GetValue());
      if(new UseGold().Use(gold)){
        ItemBag itemBag = new ItemBag(itemID,itemPeace);
        new InventoryAdd().Add(itemBag);
        AccountData.Save();
        return true;
      }
      return false;
    }
}
