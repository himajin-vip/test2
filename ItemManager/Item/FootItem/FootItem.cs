
public class FootItem
{
  ////ID500~
  public int Id{get; protected set;}
  public string Info{get; protected set;}
  public virtual void Equip(){
  }
  public virtual void UnEquip(){
  }
  public void SetId(int id){
    Id = id;
  }
  public int ReturnID(){
    return Id;
  }
  public void SetInfo(string info){
    Info = info;
  }
  public string ReturnInfo(){
    return Info;
  }
}
