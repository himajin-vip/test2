
public class HandItem
{
  ///////ID400~
  private int Id;
  private string Info;
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
