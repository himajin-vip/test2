
public class UseItem
{
  private int Id;
  private int Recovery;
    public virtual void ItemUse(string Name){
    }
    public virtual void MakeLog(){
    }
    public void SetRecovery(int recovery){
      Recovery = recovery;
    }
    public int ReturnRecovery(){
      return Recovery;
    }
    public void SetId(int id){
      Id = id;
    }
    public int ReturnID(){
      return Id;
    }
}
