
public class Item
{
  protected ItemID Id;
  protected ItemInfo Info;
  protected ItemType Type;
  protected ItemName Name;
  protected ItemPrice Price;
  protected ItemID GetID(){
    return Id;
  }
  public ItemInfo GetInfo(){
    return Info;
  }
  public ItemType getType(){
    return Type;
  }
  public ItemName GetName(){
    return Name;
  }
  public ItemPrice GetPrice(){
    return Price;
  }
}
