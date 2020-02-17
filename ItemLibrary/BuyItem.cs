
// public class BuyItem
// {
//     public bool Buy(ItemID itemID, ItemPeace itemPeace){
//       ItemPrice itemPrice = new GetItemPrice().Get(itemID,itemPeace);
//       Gold gold = new Gold(itemPrice.GetIntValue());
//       if(new UseGold().Use(gold)){
//         ItemBag itemBag = new ItemBag(itemID,itemPeace);

//         AccountData.Save();
//         return true;
//       }
//       return false;
//     }
// }
