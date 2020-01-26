
public class UseItem
{
  private int Id;
  private int Recovery;
    public virtual void ItemUse(){
      PlayerManager.Player.GetComponent<Player>().RecoveryHp(Recovery);
    }
    public void SetRecovery(int recovery){
      Recovery = recovery;
    }
    public void SetId(int id){
      Id = id;
    }
    public int ReturnID(){
      return Id;
    }
}
