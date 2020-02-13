
public class BuyItem
{
    public bool Buy(ItemID itemID, ItemPeace itemPeace){
      ItemPrice itemPrice = new GetItemPrice().Get(itemID,itemPeace);
      Gold gold = new Gold(itemPrice.GetValue());
      if(new UseGold().Use(gold)){
        new InventoryAdd().Add(itemID,itemPeace);
        AccountData.Save();
        return true;
      }
      return false;
    }
}
