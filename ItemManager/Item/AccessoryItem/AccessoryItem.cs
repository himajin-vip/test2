
public class AccessoryItem
{
  public int Id{get; protected set;}
  public string Info{get; protected set;}
  public virtual void Equip(){
  }
  public virtual void UnEquip(){
  }
}
