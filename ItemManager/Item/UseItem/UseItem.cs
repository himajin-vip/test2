
public class UseItem
{
  /////ID 0~
  private int Id;
  private string Info;
    public virtual void ItemUse(string Name){
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
