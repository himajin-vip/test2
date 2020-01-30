
public class HeadItem
{
  //ID200~
  private int Id;
  private string Info;
  public virtual void Equip(){
  }
  public virtual void UnEquip(){
  }
  public void SetId(int id){
    Id = id;
  }
  public void SetInfo(string info){
    Info = info;
  }
  public int ReturnID(){
    return Id;
  }
  public string ReturnInfo(){
    return Info;
  }
}
