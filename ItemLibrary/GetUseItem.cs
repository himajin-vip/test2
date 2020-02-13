using System;

public class GetUseItem : ItemLibrary
{    
    public UseItem Get(ItemID itemID){
      Type itemType = new GetItem().Get(itemID);
      return (UseItem)Activator.CreateInstance(itemType);
    }

}
